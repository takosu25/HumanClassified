﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : JobBase
{
    public override string GetName()
    {
        return "剣士";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return option.magicLevel.value == MagicLevel.MIN;
    }
}
