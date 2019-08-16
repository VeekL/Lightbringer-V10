using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon3 : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;
    public LineRenderer lineRenderer;
    private float extendRate = 3f; //DO NOT CHANGE THIS OTHERWISE GOT BUGS
    private float currentLength = 0f;
    private float startTime;
    private LineRenderer lr;
    private float bulletSpeed = 20f;
    public int damage = 50;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;

    private int layermask_enemy;

    void Start()
    {
        layermask_enemy = LayerMask.NameToLayer("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;

        if (Input.GetButtonDown("Fire1"))
        {
            startTime = Time.time;

            // assign fireclip and play
            ShootingAudio.clip = FireClip;
            ShootingAudio.Play();
        }

        if (Input.GetButtonUp("Fire1")) {
            ShootingAudio.Stop();
        }
        
        if (Input.GetButton("Fire1"))
        {
            // if (currentLength<maxExtension)
            // {
            //     currentLength = Time.time-startTime;
            // }
            float dist_if_no_hit = Time.time-startTime;
            RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, dist_if_no_hit, 1 << layermask_enemy);
            if (hit)
            {
                float hitting_dist = Vector2.Distance(transform.position, hit.point);
                currentLength = Mathf.Min(dist_if_no_hit, hitting_dist);
                startTime = Time.time - currentLength;

                GameObject go = Instantiate(bulletPrefab, hit.point, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = direction.normalized*bulletSpeed;
                go.GetComponent<CollisionHit>().value = damage;

            } else {
                currentLength = dist_if_no_hit;
            }
        } else {
            currentLength = 0f;
        }
        
        lineRenderer.SetPosition(1,new Vector3(0f, 10.1f, 0f)*currentLength/10.11f*extendRate);
    }
}
