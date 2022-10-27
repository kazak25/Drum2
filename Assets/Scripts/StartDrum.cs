using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDrum : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private HingeJoint _engine;
    private ReverseDrum _reverseDrum;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _engine = GetComponent<HingeJoint>();
        _rigidbody.isKinematic = true;
        _reverseDrum = GetComponent<ReverseDrum>();
    }

    // Update is called once per frame
    public void StartEngine()
    {
        var motor = _engine.motor;
        motor.force = 300;
        motor.targetVelocity = 60;
        if (_reverseDrum.weMoveClockwise)
        {
            motor.targetVelocity = -60;
        }


        _engine.motor = motor;
        _rigidbody.isKinematic = false;
    }
}