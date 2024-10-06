using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
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
        timerManager.SetTimer(60);
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
        var humanData = humans[Random.Range(0,humans.Length)];
        human.GetComponent<HumanObject>().humanData = humanData;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log($"現在の所持金：{money.GetValue()}");
            Debug.Log($"現在の信頼度：{credibility.GetValue()}");
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

    public void OpenJobPanel(){
        panel.gameObject.SetActive(true);
    }
    public void CloseJobPanel(){
        panel.gameObject.SetActive(false);
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
        timerText.text = $"残り時間：{timer}秒";
    }
    
    public Credibility GetCredibility(){
        return credibility;
    }
}
