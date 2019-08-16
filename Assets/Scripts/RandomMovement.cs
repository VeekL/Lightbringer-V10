using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SetRandomPos", 0, 0.005f);
    }

    // Update is called once per frame
    void SetRandomPos()
    {
        if (transform.position.x > 12f | transform.position.x < -12f) 
        {
            if (transform.position.x > 12f)
            {
                Vector3 moveLeft = new Vector3(Random.Range(-0.5f, -0.3f)+transform.position.x, transform.position.y, 0);
                transform.position = moveLeft;
            }
            if (transform.position.x < -12f)
            {
                Vector3 moveRight = new Vector3(Random.Range(0.5f, 0.3f)+transform.position.x, transform.position.y, 0);
                transform.position = moveRight;
            }
        }

        else
        {
            if (transform.position.y<2f | transform.position.y > 4f)
            {
                if (transform.position.y > 4f)
                {
                    Vector3 moveDown = new Vector3(transform.position.x, Random.Range(-0.5f,-0.3f)+transform.position.y, 0);
                    transform.position = moveDown;
                }
                if (transform.position.y < 2f)
                {
                    Vector3 moveUp = new Vector3(transform.position.x, Random.Range(0.5f,0.3f)+transform.position.y, 0);
                    transform.position = moveUp;
                }
            }
            else
            {
                Vector3 temp = new Vector3(Random.Range(-0.05f, 0.05f) + transform.position.x, Random.Range(-0.05f, 0.05f) + transform.position.y, 0);
                transform.position = temp;
            }
        }
     }
}

