using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlareWeardown : MonoBehaviour
{

    public void UpdateFlareWeardownText(float weardown)
    {
        GetComponent<TextMeshProUGUI>().text = weardown.ToString("F");
    }
}
