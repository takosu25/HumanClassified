using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum OrbResult
{
    Off, Unchanged, On
}
public class OrbExam : ExamBase<OrbResult>
{
    public override OrbResult Exam(ExamOption examOption)
    {
        var ability = examOption.humanData.ability;
        switch (ability)
        {
            case FireAbility:
            case NatureAbility:
            case WaterAbility:
                return OrbResult.Unchanged;
            case LightAbility:
                return OrbResult.On;
            case DarkAbility:
                return OrbResult.Off;
        }
        throw new System.NotImplementedException();
    }
}
