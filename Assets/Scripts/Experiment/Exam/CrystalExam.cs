using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CrystalResult
{
    NoLight,WeakLight,MidLight,StrongLight,Break
}

public class CrystalExam : ExamBase<CrystalResult>
{
    public override CrystalResult Exam(ExamOption examOption)
    {
        if (MagicLevel.IsNone(examOption.humanData.magicLevel))
        {
            return CrystalResult.NoLight;
        }
        else if (MagicLevel.IsWeak(examOption.humanData.magicLevel))
        {
            return CrystalResult.WeakLight;
        }
        else if (MagicLevel.IsMid(examOption.humanData.magicLevel))
        {
            return CrystalResult.MidLight;
        }
        else if (MagicLevel.IsStrong(examOption.humanData.magicLevel))
        {
            return CrystalResult.StrongLight;
        }
        else if (MagicLevel.IsSuper(examOption.humanData.magicLevel))
        {
            return CrystalResult.Break;
        }
        throw new System.ArgumentOutOfRangeException();
    }
}
