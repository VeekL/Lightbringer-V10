using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject leftwall;
    public GameObject rightwall;
    private float speed = 5.0f;
    public bool _Direction = true; //right is true
    private float XScale = 1f;
    public float charRotation = 0f;
    private Animator anm;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        anm = GetComponentInChildren<Animator>();
        sr  = GetComponentInChildren<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left shift"))
        {
            speed = 125.0f;
        }
        else
        {
            speed = 5.0f;
        }

        if (Input.GetAxis("Horizontal")!=0)
        {
            anm.Play("Walk_a");
            if (Input.GetAxis("Horizontal")>0)
            {
                sr.flipX = false;
            }
            if (Input.GetAxis("Horizontal")<0)
            {
                sr.flipX = true;
            }
        }

        if (Input.GetAxis("Horizontal")==0)
        {
            if (Input.GetButton("Fire1")) {
                anm.Play("Shoot_a");
                    if (transform.position.x > GameObject.Find("DarkLord").transform.position.x)
                {
                    sr.flipX = true;
                } else {
                    sr.flipX = false;
                }
            } else {
                anm.Play("Stand_a");
            }
        }
        
        if (Input.GetAxis("Horizontal")<0 && (transform.position.x-0.5)<leftwall.transform.position.x)
        {
            return;
        }
        if (Input.GetAxis("Horizontal")>0 && (transform.position.x+0.5)>rightwall.transform.position.x)
        {
            return;
        }


        Vector3 v = new Vector3(Input.GetAxis("Horizontal"),0.0f,0.0f);
        v = v*speed*Time.deltaTime;
        transform.Translate(v);
        // transform.Rotate.y= charRotation;

    }
}
