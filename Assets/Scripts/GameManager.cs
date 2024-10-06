using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab;

    [SerializeField]
    TimerManager timerManager;

    private GameObject human;

    private Money money = Money.Zero();

    [SerializeField]
    JobSelectionPanel panel;

    // Start is called before the first frame update
    void Start()
    {
        human = Instantiate(humanPrefab);
        Human[] humans = {
            new Human(magicLevel: new MagicLevel(1),abilityBase: new FireAbility(),new Money(3)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new FireAbility(),new Money(5)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new WaterAbility(),new Money(7)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new NatureAbility(),new Money(10)),
            new Human(magicLevel: new MagicLevel(2),abilityBase: new LightAbility(),new Money(1)),
        };
        var humanData = humans[Random.Range(0,humans.Length)];
        human.GetComponent<HumanObject>().humanData = humanData;
        panel.GetComponent<JobSelectionPanel>().SetManager(this);
        timerManager.TimeUpEvent += TimeUp;
        timerManager.SetTimer(10);
        timerManager.CountStart();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log($"現在の所持金：{money.GetValue()}");
        }
    }

    public void Checked(JobBase job){
        var humanData = human.GetComponent<HumanObject>().humanData;
        var judgedJob = new JudgeJobManager().JudgeJob(new JudgeJobOption(humanData.ability,humanData.magicLevel));
        if(judgedJob.GetType() == job.GetType()){
            money.AddValue(humanData.dropMoney.GetValue());
            Debug.Log("あたり！");
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

    private void TimeUp(){
        Debug.Log("タイムアップ！");
    }
}
