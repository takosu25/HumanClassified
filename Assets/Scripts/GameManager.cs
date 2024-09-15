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
        var humanData = new Human(magicLevel:new MagicLevel(Random.Range(MagicLevel.MIN,MagicLevel.MAX + 1)),abilityBase:new FireAbility());
        human.GetComponent<HumanObject>().humanData = humanData;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
