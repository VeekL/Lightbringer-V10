using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VidHandler : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            NextScene();
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        NextScene();
    }

    void NextScene()
    {
        SceneManager.LoadScene(4);
    }
}
