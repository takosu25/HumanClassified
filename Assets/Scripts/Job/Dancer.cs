using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancer : JobBase
{
    public override string GetName()
    {
        return "踊り子";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return MagicLevel.IsWeak(option.magicLevel) && option.abilityBase is LightAbility;
    }
}

