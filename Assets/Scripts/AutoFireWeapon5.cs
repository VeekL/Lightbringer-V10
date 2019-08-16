using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireWeapon5 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public LineRenderer lineRenderer;
    private float extendRate = 3f; //DO NOT CHANGE THIS OTHERWISE GOT BUGS
    private float currentLength = 0f;
    private float startTime;
    private LineRenderer lr;
    private float bulletSpeed = 20f;
    public int damage = 200;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;

    void Start()
    {
        startTime=Time.time;
    }

    void Update()
    {
        Vector3 target = GameObject.Find("DarkLord").transform.position;
        target.z = 0f;
        faceBoss(target);

        Vector2 direction = new Vector2(
            target.x - firepoint.position.x,
            target.y - firepoint.position.y
        );

        GameObject go = Instantiate(bulletPrefab, target, Quaternion.identity);
        go.GetComponent<Rigidbody2D>().velocity = direction.normalized*bulletSpeed;
        go.GetComponent<CollisionHit>().value = damage;

        if (!ShootingAudio.isPlaying) {
            ShootingAudio.clip = FireClip;
            ShootingAudio.Play();
        }

        if (Time.time-startTime > 10)
        {
            lineRenderer.SetWidth(0.7f,0.7f);
        } else {
            lineRenderer.SetWidth(0.2f,0.2f);
        }
        lineRenderer.SetPosition(1,new Vector3(0f, 10.1f, 0f)*direction.magnitude/7.2f);
        // lasthit+=1f;
    }

    void faceBoss(Vector3 target){
        Vector3 bossPosition = target;

        Vector2 direction = new Vector2(
            bossPosition.x - transform.position.x,
            bossPosition.y - transform.position.y
        );

        transform.up = direction;
    }
}
