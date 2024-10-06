using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField]
    public event Action TimeUpEvent;

    private int timer = 0;

    public void SetTimer(int timer){
        this.timer = timer;
    }

    public void CountStart(){
        StartCoroutine(nameof(CountUpPerSecond));
    }

    private IEnumerator CountUpPerSecond(){
        yield return new WaitForSeconds(1);
        timer -= 1;
        if(timer <= 0){
            TimeUpEvent.Invoke();
        }else{
            StartCoroutine(nameof(CountUpPerSecond));
        }
    }
}
