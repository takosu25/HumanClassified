using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satan : JobBase
{
    public override string GetName()
    {
        return "魔王";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return option.magicLevel.value == MagicLevel.MAX && option.abilityBase is DarkAbility;
    }
}
