using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobResult
{
    Satan, Hero, Dancer, Swordsman
}

public class JobFactory
{
    public static JobBase JobInstance(Enum enumJob)
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
            default:
                throw new ArgumentException("職業を渡せと言っておるだろうが");
        }

    }
}
