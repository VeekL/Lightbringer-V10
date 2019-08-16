using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon2 : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float swingArcDegrees = 60f;
    public float swingSpeed = 3f;
    private float bulletSpeed = 20f;
    public int damage = 5;

    public AudioSource ShootingAudio;
    public AudioClip FireClip;
    public AudioClip OpenClip;

    private int layermask_enemy;

    void Start()
    {
        ShootingAudio.clip = OpenClip;
        ShootingAudio.Play();
        layermask_enemy = LayerMask.NameToLayer("enemy");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1"))
        {
            float f = Mathf.PingPong(Time.time, 1/swingSpeed)*swingArcDegrees*swingSpeed - (swingArcDegrees/2);
            Vector2 face_direction = faceMouseWithOffset(f);
            transform.up = face_direction;

            RaycastHit2D hit = Physics2D.Raycast(transform.position, face_direction, 10f, 1 << layermask_enemy);
            if (hit)
            {
                GameObject go = Instantiate(bulletPrefab, hit.point, Quaternion.identity);
                go.GetComponent<Rigidbody2D>().velocity = face_direction.normalized*bulletSpeed;
                go.GetComponent<CollisionHit>().value = damage;
            }
            
            
        } else {
            Vector2 face_direction = faceMouseWithOffset(0f);
            transform.up = face_direction;
        }

        if (Input.GetButton("Fire1")) {
            // assign fireclip and play
            if (!ShootingAudio.isPlaying) {
                ShootingAudio.clip = FireClip;
                ShootingAudio.Play();
            }
        }
        if (Input.GetButtonUp("Fire1")) {
            ShootingAudio.Stop();
        }
    }

    void onDisable() {
        Debug.Log("disabled");

    }

    void onEnable() {
        Debug.Log("Enabled");
        ShootingAudio.clip = OpenClip;
        ShootingAudio.Play();
    }

    Vector2 faceMouseWithOffset(float degree_offset)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        return Rotate(direction,degree_offset);   
    }

    static Vector2 Rotate(Vector2 v, float degrees) {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);
        float tx = v.x;
        float ty = v.y;

        return new Vector2((cos * tx) - (sin * ty),(sin * tx) + (cos * ty));
    }
}
