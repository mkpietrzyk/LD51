using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemHeldText : MonoBehaviour
{
    public void UpdateHeldItemStatus(bool isHoldingItem)
    {
        GetComponent<TextMeshProUGUI>().text = isHoldingItem.ToString();
    }
}
