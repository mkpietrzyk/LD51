using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATVController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;
    private float _steeringAngle;

    public WheelCollider pkc, lkc, ltc, ptc, psc, lsc;
    public Transform pk, lk, pt, lt, ps, ls;

    public float maxSteerAngle = 30f;
    public float motorForce = 1000;


    public void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        _steeringAngle = maxSteerAngle * _horizontalInput;
        pkc.steerAngle = _steeringAngle;
        lkc.steerAngle = _steeringAngle;
        
        ltc.steerAngle = -_steeringAngle;
        ptc.steerAngle = -_steeringAngle;
        
    }

    private void Accelerate()
    {
        pkc.motorTorque = _verticalInput * motorForce;
        lkc.motorTorque = _verticalInput * motorForce;
        ltc.motorTorque = _verticalInput * motorForce;
        ptc.motorTorque = _verticalInput * motorForce;
    }
    
    private void UWP(WheelCollider collider, Transform transform)
    {
        Vector3 pos = transform.position;
        Quaternion q = transform.rotation;

        collider.GetWorldPose(out pos, out q);

        transform.position = pos;
        transform.rotation = q * Quaternion.Euler(0, 90, 0);
    }

    private void UpdateWheelPos()
    {
        UWP(lkc, lk);
        UWP(pkc, pk);
        UWP(ptc, pt);
        UWP(ltc, lt);
        UWP(psc, ps);
        UWP(lsc, ls);
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPos();
    }
}
