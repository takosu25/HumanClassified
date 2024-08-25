using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JobBase
{
    public abstract string GetName();
    public abstract bool Judge(JudgeJobOption option);
}
