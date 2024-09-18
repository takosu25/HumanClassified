using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobSelectionButton : MonoBehaviour
{
    private JobBase job;
    private JobSelectionPanel panel;

    public void Initialize(JobBase jobBase,JobSelectionPanel panel){
        this.job = jobBase;
        this.panel = panel;
    }
    public void OnPressed(){
        panel.SetSelectionJob(job);
    }
}
