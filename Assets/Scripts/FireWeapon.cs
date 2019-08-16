using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    private float bulletSpeed = 20f;
    private float instantiateLagOffset = 3.5f;
    public int damage = 1;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;

    // Update is called once per frame
    void Update()
    {

        faceMouse();

        if (Input.GetButtonDown("Fire1"))
        {
            
            // float barrelRotation = GetComponent<Transform>().localRotation.z;
            Vector3 target=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = 0f;
            Vector3 fireVector = target - transform.position;
            fireVector.Normalize();
            
            GameObject go = Instantiate(bulletPrefab, firepoint.position-instantiateLagOffset*fireVector, firepoint.rotation);
            go.GetComponent<Rigidbody2D>().velocity = fireVector*bulletSpeed;
            // set currency value of the loot
            go.GetComponent<CollisionHit>().value = damage;

            // assign fireclip and play
            ShootingAudio.clip = FireClip;
            ShootingAudio.Play();
        }

        if (Input.GetButtonUp("Fire1")) {
            ShootingAudio.Stop();
        }
    }

    void faceMouse(){
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }
}
