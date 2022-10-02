using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class SafeZoneController : MonoBehaviour
{
    public BoolVariable isInSafeZone;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerSafeBox") && !isInSafeZone.Value)
        {
            isInSafeZone.Value = true;
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerSafeBox"))
        {
            isInSafeZone.Value = false;
        }
    }
}
