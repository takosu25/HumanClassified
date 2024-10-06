using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public static Money resultMoney;
    public TextMeshProUGUI textResult;

    void Start()
    {
        // GameManagerからスコアを取得して表示
        textResult.text = "所持金: " + resultMoney.GetValue();
    }
    public void OnResultButtonPressed()
    {
        SceneManager.LoadScene("StartScene");
    }

}
