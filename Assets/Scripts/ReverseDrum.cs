using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseDrum : MonoBehaviour
{
    private HingeJoint _hingeJoint;
    public bool weMoveClockwise;
   



    // Start is called before the first frame update
    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    public void СhangeRotation()
    {
        var reverse = _hingeJoint.motor;
        reverse.targetVelocity  *= -1;
        _hingeJoint.motor = reverse;
        if (weMoveClockwise)
        {
            weMoveClockwise = !weMoveClockwise;
        }
        else
        {
            weMoveClockwise = true;
        }
        
    }

    
}

    
