using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimeText : MonoBehaviour
{
    public void SetupGameOverText(float gameCount)
    {
        int gameCountS = (int)gameCount;
        GetComponent<TextMeshProUGUI>().text = gameCountS.ToString("D3");   
    }
}
