using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireWeapon2 : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        ShootingAudio.clip = OpenClip;
        ShootingAudio.Play();
        layermask_enemy = LayerMask.NameToLayer("enemy");
    }

    // Update is called once per frame
    void Update()
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

        if (!ShootingAudio.isPlaying) {
                ShootingAudio.clip = FireClip;
                ShootingAudio.Play();
            }
    }

    Vector2 faceMouseWithOffset(float degree_offset)
    {
        Vector3 target = GameObject.Find("DarkLord").transform.position;
        target.z = 0f;

        Vector2 direction = new Vector2(
            target.x - transform.position.x,
            target.y - transform.position.y
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
