using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Schedular
{
    class Process
    {
        private double averageWaitingTime;
        public double AverageWaitingTime
        {
            get { return averageWaitingTime; }
            set { averageWaitingTime = value; }
        }
        private int arrivedTime;
        public int ArrivedTime
        {
            get { return arrivedTime; }
            set { arrivedTime = value; }
        }
        private int burstTime;         
        public int BurstTime
        {
            get { return burstTime; }
            set { burstTime = value; }
        }      
        private int processID;       
        public int ProcessID
        {
            get
            {
                return processID;
            }
            set
            {
                processID = value;
            }
        }
        private double waitingTime;
        public double WaitingTime
        {
            get { return waitingTime; }
            set { waitingTime = value; }
        }
        private int priority;
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Constructors 
        public Process()
        {
            averageWaitingTime = 0;
        }
    }
}
