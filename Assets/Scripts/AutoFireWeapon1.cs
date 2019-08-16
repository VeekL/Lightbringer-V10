using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireWeapon1 : MonoBehaviour
{

    public Transform firepoint;
    public GameObject bulletPrefab;
    private float bulletSpeed = 20f;
    private float instantiateLagOffset = 3.5f;
    public int damage = 1;
    private float lasthit = 0f;
    public float cooldown = 5f;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = GameObject.Find("DarkLord").transform.position;
        target.z = 0f;
        faceBoss(target);

        Vector3 fireVector = target - transform.position;
        fireVector.Normalize();
        
        
        if (lasthit >= cooldown) {
        GameObject go = Instantiate(bulletPrefab, firepoint.position-instantiateLagOffset*fireVector, firepoint.rotation);
        go.GetComponent<Rigidbody2D>().velocity = fireVector*bulletSpeed;
        go.GetComponent<CollisionHit>().value = damage;
        lasthit = 0f;
        ShootingAudio.clip = FireClip;
        ShootingAudio.Play();
        }
        lasthit+=1f;
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
