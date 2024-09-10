using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalObject : LabwareObjectBase
{
    public override void Exam(ExamOption examOption)
    {
        var exam = new CrystalExam();
        Debug.Log(exam.Exam(examOption));
    }
}
