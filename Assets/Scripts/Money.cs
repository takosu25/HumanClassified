using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Money
{
    private int money;

    public Money(int money){
        SetValue(money);
    }

    public static Money Zero(){
        return new Money(0);
    }

    public int GetValue(){
        return money;
    }

    public void SetValue(int money){
        this.money = money;
    }

    public void AddValue(int add){
        SetValue(money + add);
    }
}
