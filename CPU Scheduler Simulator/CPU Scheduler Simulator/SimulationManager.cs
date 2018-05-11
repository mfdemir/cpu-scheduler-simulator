using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public class SimulationManager
    {
        public int i;
        public bool isSimEnded
        {
            get
            {
                foreach (var item in schedulers)
                {
                    if (item.isEnded) return true;
                }
                return false;
            }
        }
        Random random = new Random();
        public List<Process> processes;
        public int
            maxArrivalTime = 25,
            maxBurstTime = 25,
            minPeriod = 25,
            maxPeriod = 100,
            period,
            quantum,
            totalBurstTime = 0,
            step = 0,
            processCount;

        public List<Scheduler> schedulers = new List<Scheduler>();
        public List<Process> Generate(int count)
        {
            processCount = count;
            random = new Random();
            int arrivalTime, burstTime;
            //quantum = random.Next(5, 10); //For Round Robin
            processes = new List<Process>();

            for (int i = 0; i < processCount; i++)
            {
                arrivalTime = random.Next(maxArrivalTime);
                burstTime = random.Next(1, maxBurstTime);
                //period = random.Next(burstTime > minPeriod ? burstTime : minPeriod, maxPeriod);
                Color color = Color.FromArgb(random.Next(64, 256), random.Next(64, 256), random.Next(64, 256));
                if (totalBurstTime < arrivalTime + burstTime) totalBurstTime = arrivalTime + burstTime;
                processes.Add(new Process(i, arrivalTime, burstTime, 0, color));
            }

            ResetSchedulers();
            return processes;
        }
        public void ResetSchedulers()
        {
            if (processes != null)
            {
                foreach (var sch in schedulers)
                {
                    sch.Reset(processes);
                }
            }
        }
        public Dictionary<Scheduler, double[]> MeanTurnaroundTime(int _count,BackgroundWorker bgw)
        {
            //ResetSchedulers();
            //Generate(_count);
            Dictionary<Scheduler, double[]> meanTurnaround = new Dictionary<Scheduler, double[]>();
            foreach (var sch in schedulers)
            {
                meanTurnaround.Add(sch, new double[_count]);
            }

            for (i = 1; i <= _count; i++)
            {
                List<Process> a = new List<Process>(processes.GetRange(0, i));
                foreach (var sch in schedulers)
                {
                    sch.Reset(a);
                }


                while (!isSimEnded)
                {
                    foreach (var sch in schedulers)
                    {
                        sch.Step(step);
                    }
                    step++;
                }

                foreach (var sch in schedulers)
                {
                    foreach (Process p in sch.finishedProcesses)
                    {
                        meanTurnaround[sch][i - 1] += p.endStep - p.arrivalTime;
                    }
                    meanTurnaround[sch][i - 1] /= sch.finishedProcesses.Count;
                }
                
                step = 0;
                bgw.ReportProgress(i);
            }
            return meanTurnaround;

        }
        public List<Process> Step()
        {
            //if (roundRobin.currentStep <= totalBurstTime)
            //{
            List<Process> responses = new List<Process>();
            foreach (var _scheduler in schedulers)
            {
                responses.Add(_scheduler.Step(step));
            }
            step++;
            return responses;
            //}
            //else return null;
        }

    }

}
