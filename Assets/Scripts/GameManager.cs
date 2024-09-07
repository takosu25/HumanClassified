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
        Instantiate(humanPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
