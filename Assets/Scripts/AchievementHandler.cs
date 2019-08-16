using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementHandler : MonoBehaviour
{

    public GameObject i1;
    public GameObject i2;
    public GameObject i3;
    public GameObject i4;
    public Text achievementText;
    private int count;
    private bool a1unlocked = false;
    private bool a2unlocked = false;
    private bool a3unlocked = false;
    private bool a4unlocked = false;
    public static bool a1trigger = false;
    public static bool a2trigger = false;
    public static bool a3trigger = false;
    public static bool a4trigger = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        i1.SetActive(false);
        i2.SetActive(false);
        i3.SetActive(false);
        i4.SetActive(false);
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (a1trigger && !a1unlocked)
        {
            a1unlocked = true;
            i1.SetActive(true);
            StartCoroutine(CleanUp(i1));
            count += 1;
            Currency.xul += 500;
        }
        if (a2trigger && !a2unlocked)
        {
            a2unlocked = true;
            i2.SetActive(true);
            StartCoroutine(CleanUp(i2));
            count += 1;
            Currency.xul += 500;
        }
        if (a3trigger && !a3unlocked)
        {
            a3unlocked = true;
            i3.SetActive(true);
            StartCoroutine(CleanUp(i3));
            count += 1;
            Currency.xul += 1000;
        }
        if (a4trigger && !a4unlocked)
        {
            a4unlocked = true;
            i4.SetActive(true);
            StartCoroutine(CleanUp(i4));
            count += 1;
            Currency.xul += 1000;
        }
        achievementText.text = count + " of 4 Achievements unlocked!";
    }

    IEnumerator CleanUp(GameObject go)
    {
        yield return new WaitForSeconds(3);
        go.SetActive(false);
    }
}
