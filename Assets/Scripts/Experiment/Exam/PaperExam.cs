using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PaperResult
{
    BurnOut,Smoldering,NoFire
}
public class PaperExam : ExamBase<PaperResult>
{
    public override PaperResult Exam(ExamOption examOption)
    {
        var ability = examOption.humanData.ability;
        switch (ability)
        {
            case FireAbility:
                return PaperResult.BurnOut;
            case LightAbility:
            case DarkAbility:
            case NatureAbility:
                return PaperResult.Smoldering;
            case WaterAbility:
                return PaperResult.NoFire;
        }
        throw new ArgumentException();
    }
}
