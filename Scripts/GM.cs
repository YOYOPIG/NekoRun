using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public Player player;
    public GameObject game_over;
    public GameObject timer;
    public GameObject pause_menu;
    public GameObject BGM;
    public AudioClip clip;
    public Text ctr_text;
    private float sec, min;
    private float elapsed_time;
    private bool paused, gg;

    // Use this for initialization
    void Start () {
        ctr_text = timer.GetComponent<Text>() as Text;
        sec = 0;
        min = 0;
        elapsed_time = 0;
        paused = false;
        gg = false;
        Time.timeScale = 1;
        MyNotifications.CallNotification("Run to the end!", 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if(!paused)
        {
            elapsed_time += Time.deltaTime;
            min = (int)(elapsed_time / 60f);
            sec = (int)(elapsed_time % 60f);
            ctr_text.text = min.ToString("00") + ":" + sec.ToString("00");
        }
        if (player.transform.position.y<190)
        {
            //BGM.GetComponent<AudioSource>().clip = clip;
            //BGM.GetComponent<AudioSource>().Play();
            game_over.SetActive(true);
            paused = true;
            gg = true;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!paused&&!gg)
            {
                Cursor.visible = true;
                paused = true;
                pause_menu.SetActive(true);
                Time.timeScale = 0;
            }
            else if(paused&&!gg)
            {
                Cursor.visible = false;
                paused = false;
                pause_menu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
