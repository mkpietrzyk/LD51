using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class FlareLevel : MonoBehaviour
{
    public void UpdateFlareLevel(int flareLevel)
    {
        GetComponent<TextMeshProUGUI>().text = flareLevel.ToString("D2");
    }
}
