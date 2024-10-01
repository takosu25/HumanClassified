﻿using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab;

    private GameObject human;

    private Money money = Money.Zero();

    [SerializeField]
    JobSelectionPanel panel;

    // Start is called before the first frame update
    void Start()
    {
        human = Instantiate(humanPrefab);
        Human[] humans = {
            new Human(magicLevel: new MagicLevel(1),abilityBase: new FireAbility()),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new FireAbility()),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new WaterAbility()),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new NatureAbility()),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new LightAbility()),
        };
        var humanData = humans[Random.Range(0,humans.Length)];
        human.GetComponent<HumanObject>().humanData = humanData;
        panel.GetComponent<JobSelectionPanel>().SetManager(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Checked(JobBase job){
        var humanData = human.GetComponent<HumanObject>().humanData;
        var judgedJob = new JudgeJobManager().JudgeJob(new JudgeJobOption(humanData.ability,humanData.magicLevel));
        if(judgedJob.GetType() == job.GetType()){
            Debug.Log("正解！");
        }else{
            Debug.Log("はずれ！");
        }
    }

    public void OpenJobPanel(){
        panel.gameObject.SetActive(true);
    }
    public void CloseJobPanel(){
        panel.gameObject.SetActive(false);
    }

    public Money GetMoney(){
        return money;
    }
}
