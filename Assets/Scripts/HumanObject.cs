using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanObject : MonoBehaviour
{
    public Human humanData;
    private void Start()
    {
        humanData = new Human();
        var ml = new MagicLevel();
        ml.value = 5;
        humanData.magicLevel = ml;
    }
}
