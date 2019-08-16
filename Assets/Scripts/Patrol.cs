using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public GameObject leftwall;
    public GameObject rightwall;
    public string stand;
    public string walk;
    public string shoot;
    private float speed = 3.0f;
    private Animator anm;
    private SpriteRenderer sr;
    private float xvector = 1f;
    public bool enabel = false;

    // Start is called before the first frame update
    void Start()
    {
        anm = GetComponentInChildren<Animator>();
        sr  = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!enabel){
            anm.Play(shoot);
            if (transform.position.x > GameObject.Find("DarkLord").transform.position.x)
            {
                sr.flipX = true;
            } else {
                sr.flipX = false;
            }
            return;
        }
        anm.Play(walk);
        if (xvector<0 && (transform.position.x-0.5)<leftwall.transform.position.x)
        {
            xvector = 1f;
            return;
        }
        if (xvector>0 && (transform.position.x+0.5)>rightwall.transform.position.x)
        {
            xvector = -1f;
            return;
        }

        sr.flipX = (xvector<0);

        Vector3 v = new Vector3(xvector,0.0f,0.0f);
        v = v*speed*Time.deltaTime;
        transform.Translate(v);
    }
}
