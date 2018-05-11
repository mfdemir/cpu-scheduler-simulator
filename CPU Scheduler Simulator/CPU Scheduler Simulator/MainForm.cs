using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace CPU_Scheduler_Simulator
{
    
    public partial class MainForm : Form
    {
        enum SimulationMode
        {
            oneStep,
            complete,
            nothing
        }
        SimulationMode simulationMode = SimulationMode.nothing;
        SimulationManager simulationManager;
        List<Process> processes = new List<Process>();
        ZedGraphControl zed;
        GraphPane table;
        int
            processCount,
            maxBurstTime,
            maxArrivalTime;

        public MainForm()
        {
            InitializeComponent();

            simulationManager = new SimulationManager();

            schedulersDataGrid.Rows[0].Cells[0].Value = "+";

            //statusLabel.Text = schedulersDataGrid.Rows.Count.ToString();

            //graph
            zed = graph;
            zed.IsShowPointValues = true;
            

            table = graph.GraphPane;
            table.Title.Text = "Mean Turnaround Time Graph";
            table.XAxis.Title.Text = "Process count";
            table.YAxis.Title.Text = "Mean Turnaround Time(Unit Time)";
            

            table.YAxis.Scale.MaxAuto = true;
            table.XAxis.Scale.MaxAuto = true;
            table.XAxis.MajorGrid.IsVisible = true;
            table.XAxis.MinorGrid.IsVisible = true;
            table.YAxis.MajorGrid.IsVisible = true;
            table.XAxis.MajorGrid.Color = System.Drawing.Color.Gray;
            table.YAxis.MajorGrid.Color = Color.Gray;
            
        }

        private void Step()
        {
            if(simulationManager.processes == null)
            {
                int pc;
                if (!int.TryParse(textBoxProcessCount.Text, out pc))
                {
                    MessageBox.Show("Check process count textbox!");
                    return;
                }
                Generate(pc);
            }

            List<Process> stepResponse = simulationManager.Step();

            //statusLabel.Text = "Step: " + simulationManager.step;
            //statusLabel.ForeColor = Color.BlueViolet;

            int index = stepsDataGrid.Columns.Add(simulationManager.step.ToString(), simulationManager.step.ToString());
            int i = 0;
            foreach(var resp in stepResponse)
            {
                if (resp != null)
                {
                    processesDataGrid.Rows[resp.pid].Cells[2].Value = resp.remainingBurstTime;

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Value = "P" + resp.pid;

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.BackColor =
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionBackColor = resp.color;
                }
                else
                {
                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Value = "idle";

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.BackColor =
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionBackColor = Color.FromArgb(0, 0, 0);

                    stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.ForeColor =
                        stepsDataGrid.Rows[i].Cells[simulationManager.step - 1].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                }
                i++;
            }

        }
        private void refreshStepDataGrid()
        {
            simulationManager.step = 0;

            stepsDataGrid.Columns.Clear();
            stepsDataGrid.Columns.Add("0", "0");
            stepsDataGrid.Rows.Clear();
            foreach (var sch in simulationManager.schedulers)
            {
                int tempIndex = stepsDataGrid.Rows.Add();
                stepsDataGrid.Rows[tempIndex].HeaderCell.Value = sch.name;
            }
            stepsDataGrid.Refresh();

            simulationManager.maxBurstTime = maxBurstTime;
            simulationManager.maxArrivalTime = maxArrivalTime;
            simulationManager.ResetSchedulers();

            processesDataGrid.Rows.Clear();
            processesDataGrid.Refresh();
            foreach (Process process in processes)
            {
                int index = processesDataGrid.Rows.Add("P" + process.pid.ToString(), process.initialBurstTime.ToString(), process.remainingBurstTime.ToString(), process.arrivalTime.ToString());
                processesDataGrid.Rows[index].DefaultCellStyle.BackColor = process.color;
            }
        }
        private void Generate(int processNum)
        {
            refreshStepDataGrid();
            processes = simulationManager.Generate(processNum);
            


            //simulationManager = new SimulationManager();

            




            //statusLabel.Text = "Processes generated...";
            //statusLabel.ForeColor = Color.Green;
            refreshStepDataGrid();
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            processesDataGrid.ClearSelection();
            stepsDataGrid.ClearSelection();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (simulationManager.schedulers.Count == 0)
            {
                MessageBox.Show("There are no schedulers. Please add schedulers.");
                return;
            }
            if (simulationMode != SimulationMode.oneStep)
            {
                refreshStepDataGrid();
                simulationMode = SimulationMode.oneStep;
            }
            Step();

        }

        private void schedulersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if (e.RowIndex == schedulersDataGrid.Rows.Count - 1)
                {
                    AddSchedulerForm pop = new AddSchedulerForm();
                    if (pop.ShowDialog() == DialogResult.OK)
                    {
                        if (pop.scheduler == schedulerTypes.RoundRobbin)
                        {
                            string name = "RR(Q:" + pop.value + ")";
                            Scheduler tempScheduler = new RoundRobinScheduler(name, pop.value, new List<Process>(), pop.color);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }
                        else if (pop.scheduler == schedulerTypes.FirstComeFirstServe)
                        {
                            string name = "FCFS";
                            Scheduler tempScheduler = new FirstComeFirstServeScheduler(name, new List<Process>(), pop.color);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }
                        else if (pop.scheduler == schedulerTypes.HightstResponseRatioNext)
                        {
                            string name = "HRRN";
                            Scheduler tempScheduler = new HighestResponseRatioNextScheduler(name, new List<Process>(), pop.color);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }
                        else if (pop.scheduler == schedulerTypes.EarliestDeadlineFirst)
                        {
                            string name = "EDF(D=x"+pop.value+")";
                            Scheduler tempScheduler = new EarliestDeadlineFirstScheduler(name, new List<Process>(), pop.color,pop.value);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }
                        else if (pop.scheduler == schedulerTypes.ShortestJobFirst)
                        {
                            string name = "SJF";
                            Scheduler tempScheduler = new EarliestDeadlineFirstScheduler(name, new List<Process>(), pop.color);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }
                        else if (pop.scheduler == schedulerTypes.MultilevelFeedbackQueue)
                        {
                            string name = "MLFQ-" + pop.sch[0].name + "-" + pop.sch[1].name + "-" + pop.sch[2].name;
                            List<MultiLevelableScheduler> list = new List<MultiLevelableScheduler>();
                            for(int i = 0;i<3;i++)
                            {
                                list.Add(pop.sch[i]);
                            }
                            Scheduler tempScheduler = new MultiLevelFeedbackQueueScheduler(name, pop.color,list);
                            simulationManager.schedulers.Add(tempScheduler);
                            int tempIndex = schedulersDataGrid.Rows.Add("x", name, string.Empty, tempScheduler);
                            schedulersDataGrid[2, tempIndex].Style.BackColor =
                                schedulersDataGrid[2, tempIndex].Style.SelectionBackColor = pop.color;
                        }


                    }
                }
                else
                {
                    simulationManager.schedulers.RemoveAt(e.RowIndex);
                    schedulersDataGrid.Rows.RemoveAt(e.RowIndex);
                }

                refreshStepDataGrid();
            }
            else if(e.ColumnIndex == 1 && e.RowIndex < schedulersDataGrid.Rows.Count -1)
            {
                AddSchedulerForm pop = new AddSchedulerForm();
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    if (pop.scheduler == schedulerTypes.RoundRobbin)
                    {
                        string name = "RR(Q:" + pop.value + ")";
                        Scheduler previousScheduler = simulationManager.schedulers[e.RowIndex];
                        Scheduler tempScheduler = new RoundRobinScheduler(name, pop.value, null, previousScheduler.graphColor);
                        simulationManager.schedulers[e.RowIndex] = tempScheduler;
                        schedulersDataGrid.Rows[e.RowIndex].Cells[1].Value = name;
                    }
                    else if (pop.scheduler == schedulerTypes.EarliestDeadlineFirst)
                    {
                        string name = "EDF(D=x" + pop.value + ")";
                        Scheduler previousScheduler = simulationManager.schedulers[e.RowIndex];
                        Scheduler tempScheduler = new EarliestDeadlineFirstScheduler(name, null, previousScheduler.graphColor,pop.value);
                        simulationManager.schedulers[e.RowIndex] = tempScheduler;
                        schedulersDataGrid.Rows[e.RowIndex].Cells[1].Value = name;
                    }

                }

                refreshStepDataGrid();
            }
            else if (e.ColumnIndex == 2 && e.RowIndex < schedulersDataGrid.Rows.Count - 1)
            {
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    simulationManager.schedulers[e.RowIndex].graphColor = colorDialog1.Color;
                    schedulersDataGrid[2, e.RowIndex].Style.BackColor =
                            schedulersDataGrid[2, e.RowIndex].Style.SelectionBackColor = colorDialog1.Color;
                }
            }
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            if(simulationManager.schedulers.Count == 0)
            {
                MessageBox.Show("There are no schedulers. Please add schedulers.");
                return;
            }


            if (simulationMode != SimulationMode.complete)
            {
                refreshStepDataGrid();
                simulationMode = SimulationMode.complete;
            }

            int pCount = processCount;

            double[] x = new double[pCount];

            for (int i = 1; i <= pCount; i++)
            {
                x[i - 1] = i;
            }

            Dictionary<Scheduler, double[]> database = simulationManager.MeanTurnaroundTime(pCount, backgroundWorker1);

            table.CurveList.Clear();
            foreach (var item in database)
            {
                LineItem tempLine =
                    table.AddCurve(item.Key.name, x, item.Value, item.Key.graphColor, SymbolType.VDash);
                tempLine.Line.Width = 3;
            }

            table.AxisChange();
            zed.RestoreScale(table);
        }



        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMaxBurstTime .Text, out maxBurstTime) || maxBurstTime <=0)
            {
                MessageBox.Show("Check max burst time textbox!");
                return;
            }
            if (!int.TryParse(textBoxProcessCount.Text, out processCount) || processCount <= 0)
            {
                MessageBox.Show("Check process count textbox!");
                return;
            }
            if (!int.TryParse(textBoxMaxArrivalTime.Text, out maxArrivalTime) || maxArrivalTime < 0)
            {
                MessageBox.Show("Check max arrival time textbox!");
                return;
            }
            toolStripProgressBar1.Maximum = processCount;
            toolStripProgressBar1.Step = 1;
            Generate(processCount);
            buttonSimulate.Enabled = buttonStep.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
