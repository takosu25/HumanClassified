using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager
{
    public static JobBase[] GetJobList()
    {
        JobBase[] list = {new Swordsman(),new Hero(), new Satan(), new Dancer(), new Firefighter(), new Farmer(), new Chef()};
        return list;
    }
}
