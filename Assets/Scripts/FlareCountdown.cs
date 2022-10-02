using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlareCountdown : MonoBehaviour
{
    public void UpdateFlareCountdownText(float countdown)
    {
        GetComponent<TextMeshProUGUI>().text = countdown.ToString("F");
    }
}
