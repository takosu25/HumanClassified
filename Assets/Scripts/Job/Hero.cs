using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : JobBase
{
    public override string GetName()
    {
        return "勇者";
    }

    public override bool Judge(JudgeJobOption option)
    {
        return option.magicLevel.value == MagicLevel.MAX && option.abilityBase is LightAbility;

    }
}
