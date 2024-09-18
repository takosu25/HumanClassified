using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobResult
{
    Satan, Hero, Dancer, Swordsman, Farmer, Chef, Firefighter
}

public class JobFactory
{
    public static JobBase JobInstance(JobResult enumJob)
    {
        switch (enumJob)
        {
            case JobResult.Satan:
                return new Satan();
            case JobResult.Hero:
                return new Hero();
            case JobResult.Dancer:
                return new Dancer();
            case JobResult.Swordsman:
                return new Swordsman();
            case JobResult.Farmer:
                return new Farmer();
            case JobResult.Firefighter:
                return new Firefighter();
            case JobResult.Chef:
                return new Chef();
            default:
                throw new ArgumentException("職業を渡せと言っておるだろうが");
        }

    }
}
