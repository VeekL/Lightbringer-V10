using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    public static int xul;
    public static int lastXul;
    private TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        xul = 0;
        tmp = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        if (xul != lastXul)
        {
            lastXul = xul;
            tmp.SetText( xul.ToString() + " xul" );
        }
        if (xul >= 100 && !AchievementHandler.a1trigger){
            AchievementHandler.a1trigger = true;
        }
    }

}
