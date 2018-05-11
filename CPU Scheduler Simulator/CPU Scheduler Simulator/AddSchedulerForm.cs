using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator
{
    public enum schedulerTypes
    {
        RoundRobbin,
        FirstComeFirstServe,
        HightstResponseRatioNext,
        EarliestDeadlineFirst,
        MultilevelFeedbackQueue,
        ShortestJobFirst
    }
    public partial class AddSchedulerForm : Form
    {
        Random random = new Random();
        public int value;
        public MultiLevelableScheduler[] sch = new MultiLevelableScheduler[3];
        public Color color;
        public schedulerTypes scheduler;
        public AddSchedulerForm()
        {
            InitializeComponent();
            Location = Cursor.Position;
            color = Colors.Instance.NextColor();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == (int)schedulerTypes.RoundRobbin)
            {
                EnterValueForm pop = new EnterValueForm("Enter quantum for Round Robbin:", EnterValueForm.PopUpType.Input);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    value = pop.value;
                    scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    comboBox1.SelectedItem = null;
                }
            }
            else if (comboBox1.SelectedIndex == (int)schedulerTypes.FirstComeFirstServe)
            {
                scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
            else if (comboBox1.SelectedIndex == (int)schedulerTypes.HightstResponseRatioNext)
            {
                scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
            else if (comboBox1.SelectedIndex == (int)schedulerTypes.EarliestDeadlineFirst)
            {
                EnterValueForm pop = new EnterValueForm("Max deadline is arrival time + burst time + ", EnterValueForm.PopUpType.Input);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    value = pop.value;
                    scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    comboBox1.SelectedItem = null;
                }
            }
            else if (comboBox1.SelectedIndex == (int)schedulerTypes.MultilevelFeedbackQueue)
            {
                AddMLFQForm pop = new AddMLFQForm();
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    sch = pop.queues;
                    scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    comboBox1.SelectedItem = null;
                }
            }
            else if (comboBox1.SelectedIndex == (int)schedulerTypes.ShortestJobFirst)
            {
                scheduler = (schedulerTypes)comboBox1.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
        }

    }
}
