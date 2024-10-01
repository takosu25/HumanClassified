using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Human
{
    public MagicLevel magicLevel;
    public JobBase job;
    public AbilityBase ability;
    public Money dropMoney;
    public Human(MagicLevel magicLevel,AbilityBase abilityBase,Money dropMoney)
    {
        this.magicLevel = magicLevel;
        ability = abilityBase;
        this.dropMoney = dropMoney;
    }
}
