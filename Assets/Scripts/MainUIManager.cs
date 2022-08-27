// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] float cash = 0;
    [SerializeField] TextMeshProUGUI cashText;

    [SerializeField] float totalCash = 10000;
    [SerializeField] Slider progressBar;

    public void Work()
    {
        cash += 100;
        cashText.text = $"Cash: ${cash}";
        float percentProgress = cash / totalCash;
        Debug.Log(percentProgress + "this is ");
        progressBar.value = percentProgress;
    }


}
