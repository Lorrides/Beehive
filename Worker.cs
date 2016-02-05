using System;

namespace BeeHive
{
    internal class Worker
    {



        public Worker(string[] jobsICanDo)
        {
            this._jobsICanDo = jobsICanDo;

        }

        public int ShiftLeft
        {
            get { return shiftToWork - shiftWorked; }
        }

        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }


        private string[] _jobsICanDo;
        private int shiftToWork;
        private int shiftWorked;

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < _jobsICanDo.Length; i++)
            {
                if (_jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftToWork = numberOfShifts;
                    shiftWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftWorked++;
            if (shiftWorked > shiftToWork)
            {
                shiftWorked = 0;
                shiftToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }

    }
}