using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperObject : LabwareObjectBase
{
    public override void Exam(ExamOption examOption)
    {
        var exam = new PaperExam();
        Debug.Log(exam.Exam(examOption));
    }
}
