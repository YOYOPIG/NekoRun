using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningLog : MonoBehaviour {

    public Vector3 spin_direction = new Vector3();
    private Vector3 ang_vel;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddTorque(spin_direction);
        //GetComponent<Rigidbody>().isKinematic = true;
        //ang_vel = GetComponent<Rigidbody>().angularVelocity;
    }
	
	// Update is called once per frame
	void Update () {
        //GetComponent<Rigidbody>().angularVelocity = ang_vel;
    }
}
