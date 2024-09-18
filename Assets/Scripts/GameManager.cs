using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab;

    private GameObject human;

    [SerializeField]
    JobSelectionPanel panel;

    // Start is called before the first frame update
    void Start()
    {
        human = Instantiate(humanPrefab);
        var humanData = new Human(magicLevel:new MagicLevel(1),abilityBase:new FireAbility());
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
}
