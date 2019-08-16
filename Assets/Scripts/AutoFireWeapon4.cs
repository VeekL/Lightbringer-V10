using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireWeapon4 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public int pallets = 5;
    public float cooldown = 10f;
    private float bulletSpeed = 30f;
    private float instantiateLagOffset = 3.5f;
    private float lasthit;
    public int damage = 100;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;

    // Update is called once per frame
    void Update()
    {
        Vector3 target = GameObject.Find("DarkLord").transform.position;
                target.z = 0f;

        faceBoss(target);

        if (lasthit >= cooldown) {
            // float barrelRotation = GetComponent<Transform>().localRotation.z;
            Vector3 fireVector = target - transform.position;
            fireVector.Normalize();

            for (int i = 0; i < pallets; i++)
            {
                GameObject go = Instantiate(bulletPrefab, firepoint.position - instantiateLagOffset * fireVector, firepoint.rotation);
                go.GetComponent<Rigidbody2D>().velocity = fireVector.normalized * bulletSpeed;
                go.GetComponent<CollisionHit>().value = damage;
            }

            lasthit=0f;
            // assign fireclip and play
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
