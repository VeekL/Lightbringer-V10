using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon5 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public LineRenderer lineRenderer;
    private float extendRate = 3f; //DO NOT CHANGE THIS OTHERWISE GOT BUGS
    private float currentLength = 0f;
    private float startTime;
    private LineRenderer lr;
    private float bulletSpeed = 20f;
    public int damage = 1000;

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
            mousePosition.x - firepoint.position.x,
            mousePosition.y - firepoint.position.y
        );

        transform.up = direction;

        if (Input.GetButtonDown("Fire1"))
        {
            startTime = Time.time;
            // Debug.Log(transform.position);
            // Debug.Log(firepoint.position);
        }

        if (Input.GetButtonUp("Fire1")) {
            ShootingAudio.Stop();
        }
        
        if (Input.GetButton("Fire1"))
        {
            if (!ShootingAudio.isPlaying) {
                ShootingAudio.clip = FireClip;
                ShootingAudio.Play();
            }
        
            RaycastHit2D hit = Physics2D.Raycast(firepoint.position, direction, direction.magnitude, 1 << layermask_enemy);
            if (hit)
            {
                // currentLength = hit.point.magnitude;
                currentLength = (hit.point-(Vector2)firepoint.position).magnitude;
                

                GameObject go = Instantiate(bulletPrefab, hit.point, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = direction.normalized*bulletSpeed;
                go.GetComponent<CollisionHit>().value = damage;

            } else {
                currentLength = direction.magnitude;
            }

            if (Time.time-startTime > 3)
            {
                lineRenderer.SetWidth(0.7f,0.7f);
            } else {
                lineRenderer.SetWidth(0.2f,0.2f);
            }

        } else {
            currentLength = 0f;
            lineRenderer.SetWidth(0.2f,0.2f);
        }
        lineRenderer.SetPosition(1,new Vector3(0f, 10.1f, 0f)*currentLength/7.2f);
    }
}
