using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BackToMenu : MonoBehaviour, IPointerClickHandler
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerClick(PointerEventData e)
    {
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}

