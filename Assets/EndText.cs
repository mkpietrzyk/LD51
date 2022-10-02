using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public BoolVariable hasPlayerDied;
    public BoolVariable hasPlayerWon;
    
    public void SetupGameOverText(bool gameEnded)
    {
        if (gameEnded)
        {
            if (hasPlayerDied.Value)
            {
                GetComponent<TextMeshProUGUI>().text = "You burned to Crisp!";   
            } else if (hasPlayerWon.Value)
            {
                GetComponent<TextMeshProUGUI>().text = "You escaped!";    
            }
        }
    }
}
