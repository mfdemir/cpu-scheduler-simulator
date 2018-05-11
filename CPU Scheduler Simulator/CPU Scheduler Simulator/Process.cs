using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public class Process
    {
        public double
            priority;
        public int
            pid,
            arrivalTime,
            initialBurstTime,
            remainingBurstTime,
            endStep,
            deadLine;

        public Color color;
        public Process(int _pid, int _arrivalTime, int _initialBurstTime,int _deadLine, Color _color)
        {
            pid = _pid;
            arrivalTime = _arrivalTime;
            initialBurstTime = _initialBurstTime;
            remainingBurstTime = initialBurstTime;
            deadLine = _deadLine;
            endStep = 0;
            priority = 1;
            color = _color;
        }
        public Process(Process baseProcess)
        {
            pid = baseProcess.pid;
            arrivalTime = baseProcess.arrivalTime;
            initialBurstTime = baseProcess.initialBurstTime;
            remainingBurstTime = initialBurstTime;
            deadLine = baseProcess.deadLine;
            endStep = 0;
            color = baseProcess.color;
        }

    }
}
