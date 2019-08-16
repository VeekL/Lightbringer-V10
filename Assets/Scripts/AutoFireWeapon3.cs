using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireWeapon3 : MonoBehaviour
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
    private float lasthit;

    private int layermask_enemy;

    void Start()
    {
        layermask_enemy = LayerMask.NameToLayer("enemy");
    }
    
    void Update()
    {
        Vector3 target = GameObject.Find("DarkLord").transform.position;
        target.z = 0f;
        faceBoss(target);

        Vector2 direction = new Vector2(
            target.x - transform.position.x,
            target.y - transform.position.y
        );

        if (!ShootingAudio.isPlaying) {
            ShootingAudio.clip = FireClip;
            ShootingAudio.Play();
        }

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

        lineRenderer.SetPosition(1,new Vector3(0f, 10.1f, 0f)*currentLength/10.11f*extendRate);
        
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
