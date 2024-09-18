using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JobSelectionPanel : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPrefab;
    [SerializeField]
    GameObject buttonListPanel;

    private JobBase selectionJob;

    void Start()
    {
        foreach(JobResult jobResult in Enum.GetValues(typeof(JobResult))){
            var job = JobFactory.JobInstance(jobResult);
            var button = Instantiate(buttonPrefab);
            button.GetComponent<JobSelectionButton>().Initialize(job,this);
            button.GetComponentInChildren<TextMeshProUGUI>().text = job.GetName();
            button.transform.SetParent(buttonListPanel.transform, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSelectionJob(JobBase job){
        selectionJob = job;
    }
}
