using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public abstract class Scheduler
    {
        public string name = "noname";
        public bool isEnded = false;
        public Color graphColor = Color.Black;
        public List<Process> allProcesses = null;
        public List<Process> unStartedProcesses = null;
        public List<Process> processesToRemove = null;
        public List<Process> finishedProcesses = null;

        public Process currentProcess = null;
        public abstract Process Step(int step);
        public abstract void Reset(List<Process> _processes);
    }
}
