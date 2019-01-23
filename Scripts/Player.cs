using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour {
    public GameObject speed_effect;
    private float speed;
    private bool grounded;
    private int speed_up;
    Animator anim;

	// Use this for initialization
	void Start () {
        speed = 0.1f;
        grounded = false;
        speed_up = 0;
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        //speed_effect.SetActive(false);
        anim.SetFloat("speed", 0f);
        speed = 0.1f;
        anim.SetBool("sprint", false);
        /*if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 0.15f;
            anim.SetBool("sprint", true);
        }*/
        if(speed_up!=0)
        {
            speed_up++;
            speed = 1;
            if(speed_up >= 60)
            {
                speed_up = 0;
            }
            speed_effect.SetActive(true);
        }
        else
        {
            speed_effect.SetActive(false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if(speed_up==0)
                    speed = 0.15f;
                anim.SetBool("sprint", true);
            }
            //transform.position += speed * Vector3.forward;
            anim.SetFloat("speed", speed);
            //transform.Translate(speed * Camera.main.transform.forward);
            transform.Translate(speed * Vector3.forward * Time.deltaTime *50);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.position += speed * Vector3.left;
            anim.SetFloat("speed", speed);
            transform.Translate(speed * Vector3.left * Time.deltaTime * 40);
            //transform.Translate(speed * (-1) * Camera.main.transform.right);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Camera.main.transform, 0.25f);
            //transform.rotation = Quaternion.Lerp(transform.rotation, to.rotation, Time.time * speed);

        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position += speed * Vector3.back;
            anim.SetFloat("speed", speed);
            //transform.Translate(speed * (-1) * Camera.main.transform.forward);
            transform.Translate(speed * Vector3.back * Time.deltaTime * 40);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += speed * Vector3.right;
            anim.SetFloat("speed", speed);
            transform.Translate(speed * Vector3.right * Time.deltaTime * 40);
            //transform.Translate(speed * Camera.main.transform.right);
            //player_rotation = Quaternion.LookRotation(transform.forward, Camera.main.transform.right);
            //transform.rotation = Quaternion.Lerp(transform.rotation, player_rotation, 0.25f);
        }
        
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody>().AddForce(30000 * Vector3.up);
            grounded = false;
            anim.SetBool("jump", true);
        }
    }

    public void drink()
    {

        GetComponent<AudioSource>().Play();
        speed_up = 1;
    }

    private void LateUpdate()
    {
        anim.SetFloat("speed", 0f);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            grounded = true;
            anim.SetBool("jump", false);
        }
    }
}
