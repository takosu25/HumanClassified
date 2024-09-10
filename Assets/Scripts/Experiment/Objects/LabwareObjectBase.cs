using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LabwareObjectBase : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        transform.position = mousePosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.tag.Equals("Player")) return;
        var humandata = collision.GetComponent<HumanObject>().humanData;
        var examOption = new ExamOption(humandata);
        Exam(examOption);
    }

    public abstract void Exam(ExamOption examOption);
}
