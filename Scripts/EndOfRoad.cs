using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfRoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            MyNotifications.CallNotification("成就達成 : 注意速限\n老司機別亂飆車啊", 3.0f);
        }
    }
}
