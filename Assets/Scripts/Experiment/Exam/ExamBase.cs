using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ExamBase<T>
{
    public abstract T Exam(ExamOption examOption);
}
