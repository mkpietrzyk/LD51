using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlareController : MonoBehaviour
{
    public FloatVariable flareCountdown;
    public FloatVariable flareDuration;
    public IntVariable solarFlareLevel;
    public BoolVariable isSolarFlareActive;
    public Light flareLight;

    void FixedUpdate()
    {
        if (isSolarFlareActive.Value && flareDuration.Value > 0f)
        {
            flareDuration.Value -= Time.deltaTime;
            if (flareDuration.Value < 10f && flareDuration.Value >= 7f && flareLight.intensity <= 190f)
            {
                flareLight.intensity += Time.deltaTime * 100;
            }
            else if (flareDuration.Value <= 7f && flareDuration.Value > 3f)
            {
                flareLight.intensity = Random.Range(0.9f, 1f) * 190;
            }
            else if (flareDuration.Value <= 3f && flareDuration.Value >= 0f && flareLight.intensity >= 1f)
            {
                if (flareLight.intensity >= 1f)
                {
                    flareLight.intensity -= Time.deltaTime * 100;
                }
                else
                {
                    flareLight.intensity = 1f;
                }
                
            }
        }
        else
        {
            if (flareDuration.Value < 0f)
            {
                isSolarFlareActive.Value = false;
                flareDuration.Value = flareDuration.InitialValue;
                solarFlareLevel.Value += 1;
            }
        }

        if (!isSolarFlareActive.Value && flareCountdown.Value > 0f)
        {
            flareCountdown.Value -= Time.deltaTime;
        }
        else
        {
            if (flareCountdown.Value < 0f)
            {
                isSolarFlareActive.Value = true;
                flareCountdown.Value = flareCountdown.InitialValue;
            }
        }
    }
}