using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public GameObject end_menu;
    public GameObject BGM;

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
            BGM.GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play();
            end_menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
