using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
        var exam = new CrystalExam();
        
        Debug.Log(exam.Exam(new ExamOption(humandata)));
    }
}
