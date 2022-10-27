using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDrum : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void StopEngine()
    {
        _rigidbody.isKinematic = true;
    }
    
}
