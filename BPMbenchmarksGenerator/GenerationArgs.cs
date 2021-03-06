﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPMbenchmarksGenerator.Interfaces;

namespace BPMbenchmarksGenerator
{
    public class GenerationArgs : IGenerationArgs
    {
        public int NumberOfJobs { get; set; } = -1;
        public int MachineCapacity { get; set; } = -1;
        public int JobProcessingTimeFrom { get; set; } = -1;
        public int JobProcessingTimeTo { get; set; } = -1;
        public int JobSizeFrom { get; set; } = -1;
        public int JobSizeTo { get; set; } = -1;


        public GenerationArgs() { }

        public GenerationArgs(int numberOfJobs, int machineCapacity, int jobProcessingTimeFrom, 
            int jobProcessingTimeTo, int jobSizeFrom, int jobSizeTo)
        {
            NumberOfJobs = numberOfJobs;
            MachineCapacity = machineCapacity;
            JobProcessingTimeFrom = jobProcessingTimeFrom;
            JobProcessingTimeTo = jobProcessingTimeTo;
            JobSizeFrom = jobSizeFrom;
            JobSizeTo = jobSizeTo;
        }

        public void Reset()
        {

        NumberOfJobs = -1;
        MachineCapacity = -1;
        JobProcessingTimeFrom = -1;
        JobProcessingTimeTo = -1;
        JobSizeFrom = -1;
        JobSizeTo = -1;
    }
    }
}
