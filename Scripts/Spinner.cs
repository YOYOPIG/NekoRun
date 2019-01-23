using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddTorque(0, 100, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
