using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Human
{
    public MagicLevel magicLevel;
    public JobBase job;
    public AbilityBase ability;
    public Human(MagicLevel magicLevel,AbilityBase abilityBase)
    {
        this.magicLevel = magicLevel;
        ability = abilityBase;
    }
}
