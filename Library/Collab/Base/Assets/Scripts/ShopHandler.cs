using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class ShopHandler : MonoBehaviour
{

    public GameObject button_hero_1;
    public GameObject button_hero_2;
    public GameObject button_hero_3;
    public GameObject button_hero_4;
    public GameObject button_hero_5;
    public GameObject button_hero_6;
    public GameObject button_patrol;
    public GameObject button_weapon_1;
    public GameObject button_weapon_2;
    public GameObject button_weapon_3;
    public GameObject button_weapon_4;
    public GameObject button_weapon_5;
    // public GameObject buddy1;
    // public GameObject buddy2;
    // public GameObject buddy3;
    // public GameObject buddy4;
    public GameObject bar1;
    public GameObject bar2;
    public Sprite[] spriteList;
    private readonly int upgradeCap = 13; //set accordingly

    private int selectedHero = 1;

    private int h1upgrade = 0;
    private bool h1w1bought = true;
    private bool h1w2bought = false;
    private bool h1w3bought = false;
    private bool h1w4bought = false;
    private bool h1w5bought = false;
    private int h1weapon = 0;
    private int h1w1upgrade = 0;
    private int h1w2upgrade = 0;
    private int h1w3upgrade = 0;
    private int h1w4upgrade = 0;
    private int h1w5upgrade = 0;
    
    private bool h2bought = false;
    private bool h2w1bought = false;
    private bool h2w2bought = false;
    private bool h2w3bought = false;
    private bool h2w4bought = false;
    private bool h2w5bought = false;
    private int h2upgrade = 0;
    private int h2weapon = 0;
    private int h2w1upgrade = 0;
    private int h2w2upgrade = 0;
    private int h2w3upgrade = 0;
    private int h2w4upgrade = 0;
    private int h2w5upgrade = 0;

    private bool h3bought = false;
    private bool h3w1bought = false;
    private bool h3w2bought = false;
    private bool h3w3bought = false;
    private bool h3w4bought = false;
    private bool h3w5bought = false;
    private int h3upgrade = 0;
    private int h3weapon = 0;
    private int h3w1upgrade = 0;
    private int h3w2upgrade = 0;
    private int h3w3upgrade = 0;
    private int h3w4upgrade = 0;
    private int h3w5upgrade = 0;

    private bool h4bought = false;
    private bool h4w1bought = false;
    private bool h4w2bought = false;
    private bool h4w3bought = false;
    private bool h4w4bought = false;
    private bool h4w5bought = false;
    private int h4upgrade = 0;
    private int h4weapon = 0;
    private int h4w1upgrade = 0;
    private int h4w2upgrade = 0;
    private int h4w3upgrade = 0;
    private int h4w4upgrade = 0;
    private int h4w5upgrade = 0;

    private bool h5bought = false;
    private bool h5w1bought = false;
    private bool h5w2bought = false;
    private bool h5w3bought = false;
    private bool h5w4bought = false;
    private bool h5w5bought = false;
    private int h5upgrade = 0;
    private int h5weapon = 0;
    private int h5w1upgrade = 0;
    private int h5w2upgrade = 0;
    private int h5w3upgrade = 0;
    private int h5w4upgrade = 0;
    private int h5w5upgrade = 0;

    private int h2cost = 100;
    private int h3cost = 1000;
    private int h4cost = 10000;
    private int h5cost = 100000;
    private int h6cost = 1000000;

    private int w1cost = 50;
    private int w2cost = 500;
    private int w3cost = 5000;
    private int w4cost = 20000;
    private int w5cost = 50000;

    // ratio = 12, ..., ratio of ratio = 1/(1+1/(1,2,3,...))
    // 1,2,3, ..., 12
    // 12,6,4,3,2.4,...
    // 10,120,...
    private int[] heroupgradecost = new int[]{10, 120, 720, 2880, 8640, 20736, 41472, 71095, 106642, 142190, 170628, 186139};
    private int[] w1upgradecost = new int[12];
    private int[] w2upgradecost = new int[12];
    private int[] w3upgradecost = new int[12];
    private int[] w4upgradecost = new int[12];
    private int[] w5upgradecost = new int[12];
    
    // Start is called before the first frame update
    void Start()
    {
        // button_hero_1.GetComponent<Button>().onClick.AddListener( h1click );
        // button_hero_2.GetComponent<Button>().onClick.AddListener( h2click );
        // button_hero_3.GetComponent<Button>().onClick.AddListener( h3click );
        // button_hero_4.GetComponent<Button>().onClick.AddListener( h4click );
        // button_hero_4.GetComponent<Button>().onClick.AddListener( h4click );
        // button_hero_5.GetComponent<Button>().onClick.AddListener( h5click );
        // button_hero_6.GetComponent<Button>().onClick.AddListener( h6click );

        // button_patrol.GetComponent<Button>().onClick.AddListener( w0click );
        // button_weapon_1.GetComponent<Button>().onClick.AddListener( w1click );
        // button_weapon_2.GetComponent<Button>().onClick.AddListener( w2click );
        // button_weapon_3.GetComponent<Button>().onClick.AddListener( w3click );
        // button_weapon_4.GetComponent<Button>().onClick.AddListener( w4click );
        // button_weapon_5.GetComponent<Button>().onClick.AddListener( w5click );
        
        for (int i = 0; i < 12; i++)
        {
            w1upgradecost[i]=(int)Math.Round(heroupgradecost[i]*0.5);
            w2upgradecost[i]=(int)Math.Round(heroupgradecost[i]*1.0);
            w3upgradecost[i]=(int)Math.Round(heroupgradecost[i]*1.5);
            w4upgradecost[i]=(int)Math.Round(heroupgradecost[i]*2.0);
            w5upgradecost[i]=(int)Math.Round(heroupgradecost[i]*2.5);
        }

        button_hero_2.GetComponentInChildren<TextMeshProUGUI>().SetText(h2cost.ToString()+" xul");
        button_hero_3.GetComponentInChildren<TextMeshProUGUI>().SetText(h3cost.ToString()+" xul");
        button_hero_4.GetComponentInChildren<TextMeshProUGUI>().SetText(h4cost.ToString()+" xul");
        button_hero_5.GetComponentInChildren<TextMeshProUGUI>().SetText(h5cost.ToString()+" xul");
        button_hero_6.GetComponentInChildren<TextMeshProUGUI>().SetText(h6cost.ToString()+" xul");
        button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void h1click()
    {
        selectedHero = 1;
        bar1.GetComponent<Image>().sprite = spriteList[h1upgrade];
        switch (h1weapon)
        {
        case 4:
            bar2.GetComponent<Image>().sprite = spriteList[h1w5upgrade];
            break;
        case 3:
            bar2.GetComponent<Image>().sprite = spriteList[h1w4upgrade];
            break;
        case 2:
            bar2.GetComponent<Image>().sprite = spriteList[h1w3upgrade];
            break;
        case 1:
            bar2.GetComponent<Image>().sprite = spriteList[h1w2upgrade];
            break;
        case 0:
            bar2.GetComponent<Image>().sprite = spriteList[h1w1upgrade];
            break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        if (h1w1bought){
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
        }
        if (h1w2bought){
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        }
        if (h1w3bought){
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        }
        if (h1w4bought){
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        }
        if (h1w5bought){
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        }
        switch (h1weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
        }
    }

    public void h2click()
    {
        if (!h2bought)
        {
            if (Currency.xul >= h2cost)
            {
                h2bought = true;
                Currency.xul -= h2cost;
                button_hero_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (!AchievementHandler.a4trigger){
                    AchievementHandler.a4trigger = true;
                }
            } else {
                return;
            }
        }
        selectedHero = 2;
        bar1.GetComponent<Image>().sprite = spriteList[h2upgrade];
        switch (h2weapon)
        {
        case 4:
            bar2.GetComponent<Image>().sprite = spriteList[h2w5upgrade];
            break;
        case 3:
            bar2.GetComponent<Image>().sprite = spriteList[h2w4upgrade];
            break;
        case 2:
            bar2.GetComponent<Image>().sprite = spriteList[h2w3upgrade];
            break;
        case 1:
            bar2.GetComponent<Image>().sprite = spriteList[h2w2upgrade];
            break;
        case 0:
            bar2.GetComponent<Image>().sprite = spriteList[h2w1upgrade];
            break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        if (h2w1bought){
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
        }
        if (h2w2bought){
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        }
        if (h2w3bought){
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        }
        if (h2w4bought){
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        }
        if (h2w5bought){
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        }
        switch (h2weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
        }
    }

    public void h3click()
    {
        if (!h3bought)
        {
            if (Currency.xul >= h3cost)
            {
                h3bought = true;
                Currency.xul -= h3cost;
                button_hero_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (!AchievementHandler.a4trigger){
                    AchievementHandler.a4trigger = true;
                }
            } else {
                return;
            }
        }
        selectedHero = 3;
        bar1.GetComponent<Image>().sprite = spriteList[h3upgrade];
        switch (h3weapon)
        {
        case 4:
            bar2.GetComponent<Image>().sprite = spriteList[h3w5upgrade];
            break;
        case 3:
            bar2.GetComponent<Image>().sprite = spriteList[h3w4upgrade];
            break;
        case 2:
            bar2.GetComponent<Image>().sprite = spriteList[h3w3upgrade];
            break;
        case 1:
            bar2.GetComponent<Image>().sprite = spriteList[h3w2upgrade];
            break;
        case 0:
            bar2.GetComponent<Image>().sprite = spriteList[h3w1upgrade];
            break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        if (h3w1bought){
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
        }
        if (h3w2bought){
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        }
        if (h3w3bought){
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        }
        if (h3w4bought){
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        }
        if (h3w5bought){
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        }
        switch (h3weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
        }
    }

    public void h4click()
    {
        if (!h4bought)
        {
            if (Currency.xul >= h4cost)
            {
                h4bought = true;
                Currency.xul -= h4cost;
                button_hero_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (!AchievementHandler.a4trigger){
                    AchievementHandler.a4trigger = true;
                }
            } else {
                return;
            }
        }
        selectedHero = 4;
        bar1.GetComponent<Image>().sprite = spriteList[h4upgrade];
        switch (h4weapon)
        {
        case 4:
            bar2.GetComponent<Image>().sprite = spriteList[h4w5upgrade];
            break;
        case 3:
            bar2.GetComponent<Image>().sprite = spriteList[h4w4upgrade];
            break;
        case 2:
            bar2.GetComponent<Image>().sprite = spriteList[h4w3upgrade];
            break;
        case 1:
            bar2.GetComponent<Image>().sprite = spriteList[h4w2upgrade];
            break;
        case 0:
            bar2.GetComponent<Image>().sprite = spriteList[h4w1upgrade];
            break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        if (h4w1bought){
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
        }
        if (h4w2bought){
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        }
        if (h4w3bought){
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        }
        if (h4w4bought){
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        }
        if (h4w5bought){
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        }
        switch (h4weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
        }
    }

    public void h5click()
    {
        if (!h5bought)
        {
            if (Currency.xul >= h5cost)
            {
                h5bought = true;
                Currency.xul -= h5cost;
                button_hero_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (!AchievementHandler.a4trigger){
                    AchievementHandler.a4trigger = true;
                }
            } else {
                return;
            }
        }
        selectedHero = 5;
        bar1.GetComponent<Image>().sprite = spriteList[h5upgrade];
        switch (h5weapon)
        {
        case 4:
            bar2.GetComponent<Image>().sprite = spriteList[h5w5upgrade];
            break;
        case 3:
            bar2.GetComponent<Image>().sprite = spriteList[h5w4upgrade];
            break;
        case 2:
            bar2.GetComponent<Image>().sprite = spriteList[h5w3upgrade];
            break;
        case 1:
            bar2.GetComponent<Image>().sprite = spriteList[h5w2upgrade];
            break;
        case 0:
            bar2.GetComponent<Image>().sprite = spriteList[h5w1upgrade];
            break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        if (h5w1bought){
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
        }
        if (h5w2bought){
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
        }
        if (h5w3bought){
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
        }
        if (h5w4bought){
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
        }
        if (h5w5bought){
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
        } else {
            button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
        }
        switch (h5weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
        }
    }

    public void h6click()
    {
        if (Currency.xul >= h6cost){
            Timer.end = true;
        }
    }

    public void w0click()
    {
        switch (selectedHero)
        {
            case 1:
                h1weapon = 0;
                if (h1w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h1w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h1w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h1w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h1w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                break;
            case 2:
                h2weapon = 0;
                if (h2w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h2w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h2w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h2w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h2w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                //b1 patrol
                break;
            case 3:
                h3weapon = 0;
                if (h3w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h3w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h3w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h3w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h3w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                //b2 patrol
                break;
            case 4:
                h4weapon = 0;
                if (h4w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                //b3 patrol
                break;
            case 5:
                h5weapon = 0;
                if (h5w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h5w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h5w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h5w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h5w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                //b4 patrol
                break;
            default:
                break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
        bar2.GetComponent<Image>().sprite = spriteList[12];
    }

    public void w1click()
    {
        switch (selectedHero)
        {
            case 1:
                h1weapon = 1;
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h1w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h1w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h1w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h1w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h1w1upgrade];
                break;
            case 2:
                if (!h2w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h2w1bought = true;
                        Currency.xul -= w1cost;
                        h2weapon = 1;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h2w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h2w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h2w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h2w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h2w1upgrade];
                break;
            case 3:
                if (!h3w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h3w1bought = true;
                        Currency.xul -= w1cost;
                        h3weapon = 1;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h3w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h3w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h3w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h3w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h3w1upgrade];
                break;
            case 4:
                if (!h4w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h4w1bought = true;
                        Currency.xul -= w1cost;
                        h4weapon = 1;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h4w1upgrade];
                break;
            case 5:
                if (!h4w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h4w1bought = true;
                        Currency.xul -= w1cost;
                        h4weapon = 1;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h4w1upgrade];
                break;
            default:
                break;
        }
    }
    
    public void w2click()
    {
        switch (selectedHero)
        {
            case 1:
                if (!h1w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h1w2bought = true;
                        Currency.xul -= w2cost;
                        h1weapon = 2;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h1w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h1w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h1w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h1w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h1w2upgrade];
                break;
            case 2:
                if (!h2w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h2w2bought = true;
                        Currency.xul -= w2cost;
                        h2weapon = 2;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h2w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h2w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h2w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h2w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h2w2upgrade];
                break;
            case 3:
                if (!h3w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h3w2bought = true;
                        Currency.xul -= w2cost;
                        h3weapon = 2;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h3w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h3w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h3w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h3w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h3w2upgrade];
                break;
            case 4:
                if (!h4w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h4w2bought = true;
                        Currency.xul -= w2cost;
                        h4weapon = 2;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h4w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h4w2upgrade];
                break;
            case 5:
                if (!h5w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h5w2bought = true;
                        Currency.xul -= w2cost;
                        h5weapon = 2;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h5w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h5w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h5w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h5w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h5w2upgrade];
                break;
            default:
                break;
        }
    }

    public void w3click()
    {
        switch (selectedHero)
        {
            case 1:
                if (!h1w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h1w3bought = true;
                        Currency.xul -= w3cost;
                        h1weapon = 3;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h1w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h1w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h1w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h1w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h1w3upgrade];
                break;
            case 2:
                if (!h2w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h2w3bought = true;
                        Currency.xul -= w3cost;
                        h2weapon = 3;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h2w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h2w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h2w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h2w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h2w3upgrade];
                break;
            case 3:
                if (!h3w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h3w3bought = true;
                        Currency.xul -= w3cost;
                        h3weapon = 3;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h3w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h3w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h3w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h3w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h3w3upgrade];
                break;
            case 4:
                if (!h4w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h4w3bought = true;
                        Currency.xul -= w3cost;
                        h4weapon = 3;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h4w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h4w3upgrade];
                break;
            case 5:
                if (!h5w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h5w3bought = true;
                        Currency.xul -= w3cost;
                        h5weapon = 3;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h5w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h5w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h5w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                if (h5w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h5w3upgrade];
                break;
            default:
                break;
        }
    }

    public void w4click()
    {
        switch (selectedHero)
        {
            case 1:
                if (!h1w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h1w4bought = true;
                        Currency.xul -= w4cost;
                        h1weapon = 4;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h1w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h1w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h1w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h1w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h1w4upgrade];
                break;
            case 2:
                if (!h2w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h2w4bought = true;
                        Currency.xul -= w4cost;
                        h2weapon = 4;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h2w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h2w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h2w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h2w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h2w4upgrade];
                break;
            case 3:
                if (!h3w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h3w4bought = true;
                        Currency.xul -= w4cost;
                        h3weapon = 4;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h3w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h3w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h3w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h3w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h3w4upgrade];
                break;
            case 4:
                if (!h4w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h4w4bought = true;
                        Currency.xul -= w4cost;
                        h4weapon = 4;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h4w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h4w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h4w4upgrade];
                break;
            case 5:
                if (!h5w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h5w4bought = true;
                        Currency.xul -= w4cost;
                        h5weapon = 4;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h5w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h5w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h5w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h5w5bought)
                {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText(w5cost.ToString()+" xul");
                }
                bar2.GetComponent<Image>().sprite = spriteList[h5w4upgrade];
                break;
            default:
                break;
        }
    }

    public void w5click()
    {
        switch (selectedHero)
        {
            case 1:
                if (!h1w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h1w5bought = true;
                        Currency.xul -= w5cost;
                        h1weapon = 5;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h1w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h1w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h1w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h1w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2.GetComponent<Image>().sprite = spriteList[h1w5upgrade];
                break;
            case 2:
                if (!h2w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h2w5bought = true;
                        Currency.xul -= w5cost;
                        h2weapon = 5;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h2w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h2w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h2w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h2w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2.GetComponent<Image>().sprite = spriteList[h2w5upgrade];
                break;
            case 3:
                if (!h3w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h3w5bought = true;
                        Currency.xul -= w5cost;
                        h3weapon = 5;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h3w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                if (h3w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h3w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h3w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2.GetComponent<Image>().sprite = spriteList[h3w5upgrade];
                break;
            case 4:
                if (!h4w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h4w5bought = true;
                        Currency.xul -= w5cost;
                        h4weapon = 5;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h4w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h4w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h4w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h4w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2.GetComponent<Image>().sprite = spriteList[h4w5upgrade];
                break;
            case 5:
                if (!h5w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h5w5bought = true;
                        Currency.xul -= w5cost;
                        h5weapon = 5;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                if (h5w1bought)
                {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText(w1cost.ToString()+" xul");
                }
                if (h5w2bought)
                {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText(w2cost.ToString()+" xul");
                }
                if (h5w3bought)
                {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText(w3cost.ToString()+" xul");
                }
                if (h5w4bought)
                {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                } else {
                    button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText(w4cost.ToString()+" xul");
                }
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2.GetComponent<Image>().sprite = spriteList[h5w5upgrade];
                break;
            default:
                break;
        }
    }

    public void b1click()
    {
        switch (selectedHero)
        {
            case 1:
                if (Currency.xul >= heroupgradecost[h1upgrade])
                {
                    Currency.xul -= heroupgradecost[h1upgrade];
                    h1upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h1upgrade];
                break;
            case 2:
                if (Currency.xul >= heroupgradecost[h2upgrade])
                {
                    Currency.xul -= heroupgradecost[h2upgrade];
                    h2upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h2upgrade];
                break;
            case 3:
                if (Currency.xul >= heroupgradecost[h3upgrade])
                {
                    Currency.xul -= heroupgradecost[h3upgrade];
                    h3upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h3upgrade];
                break;
            case 4:
                if (Currency.xul >= heroupgradecost[h4upgrade])
                {
                    Currency.xul -= heroupgradecost[h4upgrade];
                    h4upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h4upgrade];
                break;
            case 5:
                if (Currency.xul >= heroupgradecost[h5upgrade])
                {
                    Currency.xul -= heroupgradecost[h5upgrade];
                    h5upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h5upgrade];
                break;
            default:
                Debug.Log(selectedHero);
                break;
        }
    }

    public void b2click()
    {
        switch (selectedHero)
        {
            case 1:
                switch (h1weapon)
                {
                    case 0:
                        bar2.GetComponent<Image>().sprite = spriteList[12];
                        break;
                    case 1:
                        if (Currency.xul >= w1upgradecost[h1w1upgrade])
                        {
                            Currency.xul -= w1upgradecost[h1w1upgrade];
                            h1w1upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h1w1upgrade];
                        break;
                    case 2:
                        if (Currency.xul >= w2upgradecost[h1w2upgrade])
                        {
                            Currency.xul -= w2upgradecost[h1w2upgrade];
                            h1w2upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h1w2upgrade];
                        break;
                    case 3:
                        if (Currency.xul >= w3upgradecost[h1w3upgrade])
                        {
                            Currency.xul -= w3upgradecost[h1w3upgrade];
                            h1w3upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h1w3upgrade];
                        break;
                    case 4:
                        if (Currency.xul >= w4upgradecost[h1w4upgrade])
                        {
                            Currency.xul -= w4upgradecost[h1w4upgrade];
                            h1w4upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h1w4upgrade];
                        break;
                    case 5:
                        if (Currency.xul >= w5upgradecost[h1w5upgrade])
                        {
                            Currency.xul -= w5upgradecost[h1w5upgrade];
                            h1w5upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h1w5upgrade];
                        break;
                    default:
                        Debug.Log(h1weapon);
                        break;
                }
                break;
            case 2:
                switch (h2weapon)
                {
                    case 0:
                        bar2.GetComponent<Image>().sprite = spriteList[12];
                        break;
                    case 1:
                        if (Currency.xul >= w1upgradecost[h2w1upgrade])
                        {
                            Currency.xul -= w1upgradecost[h2w1upgrade];
                            h2w1upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h2w1upgrade];
                        break;
                    case 2:
                        if (Currency.xul >= w2upgradecost[h2w2upgrade])
                        {
                            Currency.xul -= w2upgradecost[h2w2upgrade];
                            h2w2upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h2w2upgrade];
                        break;
                    case 3:
                        if (Currency.xul >= w3upgradecost[h2w3upgrade])
                        {
                            Currency.xul -= w3upgradecost[h2w3upgrade];
                            h2w3upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h2w3upgrade];
                        break;
                    case 4:
                        if (Currency.xul >= w4upgradecost[h2w4upgrade])
                        {
                            Currency.xul -= w4upgradecost[h2w4upgrade];
                            h2w4upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h2w4upgrade];
                        break;
                    case 5:
                        if (Currency.xul >= w5upgradecost[h2w5upgrade])
                        {
                            Currency.xul -= w5upgradecost[h2w5upgrade];
                            h2w5upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h2w5upgrade];
                        break;
                    default:
                        Debug.Log(h2weapon);
                        break;
                }
                break;
            case 3:
                switch (h3weapon)
                {
                    case 0:
                        bar2.GetComponent<Image>().sprite = spriteList[12];
                        break;
                    case 1:
                        if (Currency.xul >= w1upgradecost[h3w1upgrade])
                        {
                            Currency.xul -= w1upgradecost[h3w1upgrade];
                            h3w1upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h3w1upgrade];
                        break;
                    case 2:
                        if (Currency.xul >= w2upgradecost[h3w2upgrade])
                        {
                            Currency.xul -= w2upgradecost[h3w2upgrade];
                            h3w2upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h3w2upgrade];
                        break;
                    case 3:
                        if (Currency.xul >= w3upgradecost[h3w3upgrade])
                        {
                            Currency.xul -= w3upgradecost[h3w3upgrade];
                            h3w3upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h3w3upgrade];
                        break;
                    case 4:
                        if (Currency.xul >= w4upgradecost[h3w4upgrade])
                        {
                            Currency.xul -= w4upgradecost[h3w4upgrade];
                            h3w4upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h3w4upgrade];
                        break;
                    case 5:
                        if (Currency.xul >= w5upgradecost[h3w5upgrade])
                        {
                            Currency.xul -= w5upgradecost[h3w5upgrade];
                            h3w5upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h3w5upgrade];
                        break;
                    default:
                        Debug.Log(h3weapon);
                        break;
                }
                break;
            case 4:
                switch (h4weapon)
                {
                    case 0:
                        bar2.GetComponent<Image>().sprite = spriteList[12];
                        break;
                    case 1:
                        if (Currency.xul >= w1upgradecost[h4w1upgrade])
                        {
                            Currency.xul -= w1upgradecost[h4w1upgrade];
                            h4w1upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h4w1upgrade];
                        break;
                    case 2:
                        if (Currency.xul >= w2upgradecost[h4w2upgrade])
                        {
                            Currency.xul -= w2upgradecost[h4w2upgrade];
                            h4w2upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h4w2upgrade];
                        break;
                    case 3:
                        if (Currency.xul >= w3upgradecost[h4w3upgrade])
                        {
                            Currency.xul -= w3upgradecost[h4w3upgrade];
                            h4w3upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h4w3upgrade];
                        break;
                    case 4:
                        if (Currency.xul >= w4upgradecost[h4w4upgrade])
                        {
                            Currency.xul -= w4upgradecost[h4w4upgrade];
                            h4w4upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h4w4upgrade];
                        break;
                    case 5:
                        if (Currency.xul >= w5upgradecost[h4w5upgrade])
                        {
                            Currency.xul -= w5upgradecost[h4w5upgrade];
                            h4w5upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h4w5upgrade];
                        break;
                    default:
                        Debug.Log(h4weapon);
                        break;
                }
                break;
            case 5:
                switch (h5weapon)
                {
                    case 0:
                        bar2.GetComponent<Image>().sprite = spriteList[12];
                        break;
                    case 1:
                        if (Currency.xul >= w1upgradecost[h5w1upgrade])
                        {
                            Currency.xul -= w1upgradecost[h5w1upgrade];
                            h5w1upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h5w1upgrade];
                        break;
                    case 2:
                        if (Currency.xul >= w2upgradecost[h5w2upgrade])
                        {
                            Currency.xul -= w2upgradecost[h5w2upgrade];
                            h5w2upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h5w2upgrade];
                        break;
                    case 3:
                        if (Currency.xul >= w3upgradecost[h5w3upgrade])
                        {
                            Currency.xul -= w3upgradecost[h5w3upgrade];
                            h5w3upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h5w3upgrade];
                        break;
                    case 4:
                        if (Currency.xul >= w4upgradecost[h5w4upgrade])
                        {
                            Currency.xul -= w4upgradecost[h5w4upgrade];
                            h5w4upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h5w4upgrade];
                        break;
                    case 5:
                        if (Currency.xul >= w5upgradecost[h5w5upgrade])
                        {
                            Currency.xul -= w5upgradecost[h5w5upgrade];
                            h5w5upgrade +=1;
                            if (!AchievementHandler.a3trigger){
                                AchievementHandler.a3trigger = true;
                            }
                        }
                        bar2.GetComponent<Image>().sprite = spriteList[h5w5upgrade];
                        break;
                    default:
                        Debug.Log(h5weapon);
                        break;
                }
                break;
            default:
                Debug.Log(selectedHero);
                break;
        }
    }
}
