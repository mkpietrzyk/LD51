using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthNumber : MonoBehaviour
{
    public void SetPlayerHealth(float hp)
    {
        GetComponent<TextMeshProUGUI>().text = hp.ToString("F");
    }
}
