using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private TextMeshProUGUI tmp;
    private float startTime;
    public static bool end;
    private bool ended;
    public static float timeDiff;
    
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        startTime = Time.time;
        ended = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float deltaTime;
        float secondCount;
        float minuteCount;
        // float hourCount;

        if (end){
            if (!ended){
                // stop timer when win
                timeDiff = Time.time - startTime;
                Debug.Log(timeDiff);
                ended = true;
                SceneManager.LoadScene(3);
            }
            deltaTime = timeDiff;
        } else {
            deltaTime = Time.time-startTime;
        }
        secondCount = deltaTime%60;
        minuteCount = (int)(deltaTime/60);
        // hourCount = (int)(deltaTime/3600);
        tmp.SetText( minuteCount.ToString("00") +":"+secondCount.ToString("00.00") );
        
    }

}
