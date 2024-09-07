using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject humanPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var human = Instantiate(humanPrefab);
        var humanData = new Human(magicLevel:new MagicLevel(3),abilityBase:new DarkAbility());
        human.GetComponent<HumanObject>().humanData = humanData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
