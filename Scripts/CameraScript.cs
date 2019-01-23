using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;

    private float distance = 8;
    private float rotX = 0;
    private float rotY = 20;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotX += Input.GetAxis("Mouse X") * 2;
        if(rotY - Input.GetAxis("Mouse Y") * 2>10&& rotY - Input.GetAxis("Mouse Y") * 2<45)
        {
            rotY -= Input.GetAxis("Mouse Y") * 2;
        }
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = new Quaternion();
        rotation = Quaternion.Euler(rotY, rotX, 0);
        if (transform.position.y > 190)
        {
            transform.position = target.position + rotation * dir;
            transform.LookAt(target.position);
        }
        Quaternion player_rotation = Quaternion.Euler(0, rotX, 0);
        target.transform.rotation = player_rotation;
    }
}
