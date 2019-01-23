using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingGround : MonoBehaviour {

    public Vector3 direction = new Vector3();
    public int speed = 6;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray myRay = new Ray(transform.position, direction);
        RaycastHit hit;
        //RaycastHit hit = Physics.Raycast(transform.position, new Vector3(0, 0, 0));
        gameObject.GetComponent<Rigidbody>().velocity = direction * speed;
        if (Physics.Raycast(myRay, out hit, 6))
        {
            //flip if too close to wall
            direction = -1 * direction;
        }
    }    
}
