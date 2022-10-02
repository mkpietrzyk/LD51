using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public BoolVariable isInSafeZone;
    public BoolVariable isSolarFlareActive;
    public BoolVariable hasPlayerDied;
    public BoolVariable hasPlayerWon;
    public FloatVariable playerHealth;
    public IntVariable pickupCount;
    public IntVariable pickupWinCondition;
    public FloatVariable gameTime;
    

    private void Update()
    {
        if (!isInSafeZone.Value && isSolarFlareActive.Value)
        {
            if (playerHealth.Value >= 0f)
            {
                playerHealth.Value -= Time.deltaTime * 100;
            }
            else
            {
                hasPlayerDied.Value = true;
            }
        }

        if (pickupCount.Value == pickupWinCondition.Value)
        {
            hasPlayerWon.Value = true;
        }

        if (!hasPlayerWon.Value && !hasPlayerDied.Value)
        {
            gameTime.Value += Time.deltaTime;
        }
    }
}
