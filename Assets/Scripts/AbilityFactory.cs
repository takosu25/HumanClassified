using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityResult
{
    Fire,Water,Nature,Light,Dark
}
public class AbilityFactory
{
    public static AbilityBase AbilityInstance(AbilityResult abilityResult)
    {
        switch (abilityResult)
        {
            case AbilityResult.Fire:
                return new FireAbility();
            case AbilityResult.Water:
                return new WaterAbility();
            case AbilityResult.Nature:
                return new NatureAbility();
            case AbilityResult.Light:
                return new LightAbility();
            case AbilityResult.Dark:
                return new DarkAbility();
            default:
                throw new ArgumentException("属性を渡せと言っておるだろうが");

        }
    }
}
