using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsEnemyBoss : MonoBehaviour
{
    public GameObject leftwall;
    public GameObject rightwall;
    public GameObject character;
    public float speed = 3.0f;
    public bool _Direction = true; //right is true
    private float XScale = 1f;
    public float charRotation = 0f;
    private Animator anm;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        anm = GetComponentInChildren<Animator>();
        sr = GetComponentInChildren<SpriteRenderer>();
        // transform.position=new Vector3(-3f,0f,0f);
        // character.transform.position=new Vector3(-3f,0f,0f);
    }
    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Vector3 target = GameObject.Find("DarkLord").transform.position;
        target.x -= 0.03f;
        target.y = 0;
        transform.position = Vector3.MoveTowards(transform.position,target,step);
        // character.transform.position = Vector3.MoveTowards(transform.position,target,step);
    }

}
