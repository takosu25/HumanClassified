using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Human
{
    private int magicLevel;
    private JobBase job;
    private AbilityBase ability;

    public int GetMagicLevel()
    {
        return magicLevel;
    }

    public void SetMagicLevel(int magicLevel)
    {
        this.magicLevel = magicLevel;
    }

    public JobBase GetJob() { 
        return job;
    }

    public void SetJob(JobBase job)
    {
        this.job = job;
    }

    public AbilityBase GetAbilityBase()
    {
        return ability;
    }

    public void SetAbilityBase(AbilityBase ability)
    {
        this.ability = ability;
    }
}
