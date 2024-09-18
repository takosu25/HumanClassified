using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chef : JobBase
{
    public override string GetName()
    {
        return "料理人";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return MagicLevel.IsWeak(option.magicLevel) && option.abilityBase is FireAbility;
    }
}
