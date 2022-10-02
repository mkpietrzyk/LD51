using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public IntVariable pickupCount;
    public BoolVariable isHoldingItem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isHoldingItem.Value)
        {
            transform.parent = other.transform;
            transform.localRotation = Quaternion.identity;
            transform.localPosition = new Vector3(0, -0.1f, -0.6f);
            isHoldingItem.Value = true;
        }

        if (other.CompareTag("Warehouse") && isHoldingItem.Value)
        {
            pickupCount.Value += 1;
            Destroy(gameObject);
            isHoldingItem.Value = false;
        }
    }
}
