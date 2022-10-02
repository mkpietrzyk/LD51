using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SafeZoneStatus : MonoBehaviour
{
    public void UpdateSafeZoneStatus(bool status)
    {
        GetComponent<TextMeshProUGUI>().text = status.ToString();
    }
}
