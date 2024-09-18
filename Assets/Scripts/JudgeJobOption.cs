using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeJobOption
{
    public AbilityBase abilityBase;

    public MagicLevel magicLevel;
    

    public JudgeJobOption(AbilityBase abilityBase, MagicLevel magicLevel){
        this.abilityBase = abilityBase;
        this.magicLevel = magicLevel;
    }
}
