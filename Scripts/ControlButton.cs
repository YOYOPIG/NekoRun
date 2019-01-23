using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ControlButton : MonoBehaviour, IPointerClickHandler{

    public GameObject main;
    public GameObject ctrl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnPointerClick(PointerEventData e)
    {
        main.SetActive(false);
        ctrl.SetActive(true);
    }
}
