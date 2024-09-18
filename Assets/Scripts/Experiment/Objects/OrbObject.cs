using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbObject : LabwareObjectBase
{
    public override void Exam(ExamOption examOption)
    {
        var exam = new OrbExam();
        Debug.Log(exam.Exam(examOption));
    }
}
