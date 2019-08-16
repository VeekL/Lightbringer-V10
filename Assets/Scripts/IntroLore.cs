using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroLore : MonoBehaviour
{

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            NextScene();
        }
        if (Time.time-startTime > 40f)
        {
            NextScene();
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
