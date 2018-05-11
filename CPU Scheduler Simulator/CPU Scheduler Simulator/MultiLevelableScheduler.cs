using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public abstract class MultiLevelableScheduler : Scheduler
    {
        public Queue<Process> processQueue = null;
        public int duration;
        public int number;
        public abstract bool isQuantumUsed();
        public abstract Process Step(MultiLevelFeedbackQueueScheduler sender);
    }
}
