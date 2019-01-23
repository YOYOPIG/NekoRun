using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {
    public Transform coin;

	// Use this for initialization
	void Start () {
        //test
        Transform c = Instantiate(coin);
        c.parent = transform;
        c.transform.position = new Vector3(Random.Range(-180, 20), Random.Range(220, 200), Random.Range(180, 100));
        Transform c2 = Instantiate(coin);
        c2.parent = transform;
        c2.transform.position = new Vector3(Random.Range(-180, 20), Random.Range(220, 200), Random.Range(180, 100));
        Transform c3 = Instantiate(coin);
        c3.parent = transform;
        c3.transform.position = new Vector3(Random.Range(-180, 20), Random.Range(220, 200), Random.Range(180, 100));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
