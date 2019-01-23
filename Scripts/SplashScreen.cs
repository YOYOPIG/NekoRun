using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SplashScreen : MonoBehaviour {
    public float timer = 2f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    IEnumerator DisplayScene()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(0);
    }
}
