using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : JobBase
{
    public override string GetName()
    {
        return "農家";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return MagicLevel.IsWeak(option.magicLevel) && option.abilityBase is NatureAbility;
    }
}
