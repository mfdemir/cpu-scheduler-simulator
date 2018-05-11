using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduler_Simulator
{
    public class MultiLevelFeedbackQueueScheduler : Scheduler
    {
        public List<MultiLevelableScheduler> queues;
        public MultiLevelableScheduler currentQueue;
        public int step;
        public int counter = 0;
        public MultiLevelFeedbackQueueScheduler(string _name, System.Drawing.Color _graphColor, List<MultiLevelableScheduler> _queues)
        {
            name = _name;
            graphColor = _graphColor;
            queues = _queues;
        }
        public override void Reset(List<Process> _processes)
        {
            List<Process> copyProcesses = new List<Process>();
            foreach (var item in _processes)
            {
                copyProcesses.Add(new Process(item));
            }
            allProcesses = new List<Process>(copyProcesses);
            unStartedProcesses = new List<Process>(allProcesses);
            finishedProcesses = new List<Process>();
            currentProcess = null;
            isEnded = false;
            foreach (var item in allProcesses)
            {
                item.remainingBurstTime = item.initialBurstTime;
                item.endStep = 0;
            }
            foreach (var queue in queues)
            {
                queue.Reset(new List<Process>());
            }
            currentQueue = queues[0];
            counter = 0;
        }
        public override Process Step(int step)
        {
            this.step = step;
            processesToRemove = new List<Process>();
            foreach (Process process in unStartedProcesses)
            {
                if (process.arrivalTime == step)
                {
                    queues[0].processQueue.Enqueue(process);
                    processesToRemove.Add(process);
                }
            }
            foreach (var process in processesToRemove)
            {
                unStartedProcesses.Remove(process);
            }
            int i = 0;
            if (currentQueue.currentProcess == null)
            {
                foreach (var q in queues)
                {
                    if (q.processQueue.Count > 0)
                    {
                        counter = i;
                        currentQueue = q;
                        q.currentProcess = q.processQueue.Dequeue();
                        break;
                    }
                    i++;
                }
            }
            if (currentQueue.currentProcess != null)
            {
                if (currentQueue.currentProcess.remainingBurstTime <= 0)
                {
                    currentQueue.currentProcess.endStep = step;
                    finishedProcesses.Add(currentQueue.currentProcess);
                    currentQueue.currentProcess = null;
                    i = 0;
                    foreach (var q in queues)
                    {
                        if (q.processQueue.Count > 0)
                        {
                            counter = i;
                            currentQueue = q;
                            q.currentProcess = q.processQueue.Dequeue();
                            q.duration = 0;
                            break;
                        }
                        i++;
                    }
                    if (currentQueue.currentProcess == null)
                    {
                        if (finishedProcesses.Count == allProcesses.Count)
                        {
                            isEnded = true;
                        }
                        return null;
                    }
                }
                else if (currentQueue.isQuantumUsed())
                {

                    if (currentQueue == queues[queues.Count - 1])
                    {
                        currentQueue.processQueue.Enqueue(currentQueue.currentProcess);
                        currentQueue.currentProcess = currentQueue.processQueue.Dequeue();
                        currentQueue.duration = 0;
                    }
                    else
                    {
                        queues[++counter].processQueue.Enqueue(currentQueue.currentProcess);
                        currentQueue = queues[counter];
                        i = 0;
                        foreach (var q in queues)
                        {
                            if (q.processQueue.Count > 0)
                            {
                                counter = i;
                                currentQueue = q;
                                break;
                            }
                            i++;
                        }
                        currentQueue.currentProcess = currentQueue.processQueue.Dequeue();
                        currentQueue.duration = 0;
                    }
                }
                currentQueue.currentProcess.remainingBurstTime -= 1;
                currentQueue.duration++;
            }

            return currentQueue.currentProcess;
        }

    }
}
