using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrink : MonoBehaviour {
    public Player player;
    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().AddTorque(0, 100, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.drink();
            Destroy(gameObject);
        }
    }
}
