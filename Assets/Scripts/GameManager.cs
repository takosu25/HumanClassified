﻿using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab;

    [SerializeField]
    TimerManager timerManager;

    private GameObject human;

    private Money money = Money.Zero();
    private Credibility credibility = Credibility.Zero();

    [SerializeField]
    JobSelectionPanel panel;
    [SerializeField]
    TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        panel.GetComponent<JobSelectionPanel>().SetManager(this);
        timerManager.TimeUpEvent += TimeUp;
        timerManager.CountUpEvent += RefreshTimerText;
        timerManager.SetTimer(180);
        timerManager.CountStart();
        InstantiateHuman();
    }

    private void InstantiateHuman(){
        human = Instantiate(humanPrefab);
        Human[] humans = {
            new Human(magicLevel: new MagicLevel(1),abilityBase: new FireAbility(),new Money(4)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new FireAbility(),new Money(5)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new WaterAbility(),new Money(6)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new NatureAbility(),new Money(5)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new LightAbility(),new Money(4)),
        };
        var humanData = humans[UnityEngine.Random.Range(0,humans.Length)];
        human.transform.position = new Vector3(0,-1f,0);
        human.GetComponent<HumanObject>().humanData = humanData;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log($"現在の所持金：{money.GetValue()}");
            Debug.Log($"現在の信頼度：{credibility.GetValue()}");
            SwitchPanel();
        }
    }

    public void Checked(JobBase job){
        var humanData = human.GetComponent<HumanObject>().humanData;
        var judgedJob = new JudgeJobManager().JudgeJob(new JudgeJobOption(humanData.ability,humanData.magicLevel));
        if(judgedJob.GetType() == job.GetType()){
            money.AddValue(humanData.dropMoney.GetValue());
            credibility.AddValue(1);
            Debug.Log("あたり！");
        }else{
            credibility.RemoveValue(100);
            Debug.Log("はずれ！");
        }
        Debug.Log("-----------------------------");
        CloseJobPanel();
        Destroy(human);
        InstantiateHuman();
    }

    private void OpenJobPanel(){
        panel.gameObject.SetActive(true);
    }
    private void CloseJobPanel(){
        panel.gameObject.SetActive(false);
    }
    public void SwitchPanel(){
        bool isActive = panel.gameObject.activeSelf;
        if(isActive){
            CloseJobPanel();
        }else{
            OpenJobPanel();
        }

    }

    public Money GetMoney(){
        return money;
    }

    /// 制限時間が終了したとき呼ばれる
    private void TimeUp(){
        ResultManager.resultMoney = money;
        SceneManager.LoadScene("ResultScene");
        Debug.Log("タイムアップ！");
    }

    /// タイマーのテキストを更新する
    private void RefreshTimerText(int timer){
        TimeSpan timeSpan = TimeSpan.FromSeconds(timer);
        timerText.text = timeSpan.ToString(@"mm\:ss");
    }
    
    public Credibility GetCredibility(){
        return credibility;
    }
}
