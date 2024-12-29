using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI degrees;
    // Start is called before the first frame update
    void Update()
    {
        float tempCur = temperature.temperatureCurrent;
        float temptext = Mathf.Round(tempCur * 10.0f) * 0.1f;
        degrees.text = temptext.ToString();

    }
}
