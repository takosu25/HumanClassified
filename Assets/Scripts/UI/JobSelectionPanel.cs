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

    private GameManager manager;
    public void Initialize(GameManager manager){
        this.manager = manager;
    }

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
    public void SetSelectionJob(JobBase job){
        selectionJob = job;
        manager.Checked(job);
    }

    public void SetManager(GameManager manager){
        this.manager = manager;
    }
}
