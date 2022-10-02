using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class PickupCounter : MonoBehaviour
{
    public IntVariable pickupWinCondition;

    public void UpdatePickupCounter(int pickupCount)
    {
        GetComponent<TextMeshProUGUI>().text = string.Format("{0} / {1}", pickupCount, pickupWinCondition.Value);
    }
}