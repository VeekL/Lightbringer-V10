using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTimer : MonoBehaviour
{

    private TextMeshProUGUI tmp;
    
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        float deltaTime = Timer.timeDiff;
        float secondCount = deltaTime%60;
        float minuteCount = (int)(deltaTime/60);
        tmp.SetText( minuteCount.ToString("00") +":"+secondCount.ToString("00.00") );
    }

    void Update()
    {
        
    }
}
