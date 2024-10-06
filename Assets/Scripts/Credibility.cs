using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credibility
{
    private int credibility;

    public Credibility(int credibility){
        SetValue(credibility);
    }

    public static Credibility Zero(){
        return new Credibility(0);
    }

    public int GetValue(){
        return credibility;
    }

    public void SetValue(int credibility){
        this.credibility = credibility;
    }

    public void AddValue(int add){
        SetValue(credibility + add);
    }

    public void RemoveValue(int remove){
        SetValue(credibility - remove);
    }
}
