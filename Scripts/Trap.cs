using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
    public int id;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            if(id==1)
            {
                GetComponent<Rigidbody>().AddForce(0, 1000000, 100000);
                MyNotifications.CallNotification("成就達成 : Almost there!\nNot Today, Dude!", 3.0f);
            }
            if(id==0)
            {
                MyNotifications.CallNotification("成就達成 : 成功沒有捷徑\nhehe XD", 3.0f);
            }
        }
    }
}
