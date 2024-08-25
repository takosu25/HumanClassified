using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeJobManager
{
    public JobBase JudgeJob(JudgeJobOption option)
    {
        foreach(JobBase job in JobManager.GetJobList())
        {
            if (job.Judge(option))
            {
                return job;
            }
        }

        throw new System.ArgumentOutOfRangeException();
    }
}
