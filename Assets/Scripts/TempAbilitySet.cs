using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempAbilitySet : MonoBehaviour
{
    public int magicLevel;
    public AbilityBase abilityBase;
    public TempAbilitySet(int magicLevel,AbilityBase abilityBase){
        this.magicLevel = magicLevel;
        this.abilityBase = abilityBase;
    }
}
