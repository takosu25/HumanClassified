using System;
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
        var index = UnityEngine.Random.Range(0,Enum.GetNames(typeof(AbilityResult)).Length);
        var ability = (AbilityResult)Enum.ToObject(typeof(AbilityResult), index);
        var humanData = new Human(magicLevel:new MagicLevel(UnityEngine.Random.Range(MagicLevel.MIN,MagicLevel.MAX + 1)),abilityBase:AbilityFactory.AbilityInstance(ability));
        human.GetComponent<HumanObject>().humanData = humanData;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
