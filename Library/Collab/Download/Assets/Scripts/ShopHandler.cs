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
    
    public GameObject h1w1_go;
    public GameObject h1w2_go;
    public GameObject h1w3_go;
    public GameObject h1w4_go;
    public GameObject h1w5_go;
    
    public GameObject h2w1_go;
    public GameObject h2w2_go;
    public GameObject h2w3_go;
    public GameObject h2w4_go;
    public GameObject h2w5_go;
    
    public GameObject h3w1_go;
    public GameObject h3w2_go;
    public GameObject h3w3_go;
    public GameObject h3w4_go;
    public GameObject h3w5_go;
    
    public GameObject h4w1_go;
    public GameObject h4w2_go;
    public GameObject h4w3_go;
    public GameObject h4w4_go;
    public GameObject h4w5_go;
    
    public GameObject h5w1_go;
    public GameObject h5w2_go;
    public GameObject h5w3_go;
    public GameObject h5w4_go;
    public GameObject h5w5_go;

    public GameObject h2_go;
    public GameObject h3_go;
    public GameObject h4_go;
    public GameObject h5_go;

    public GameObject heroindicator;
    public GameObject weaponindicator;
    

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

    private float[] indicator_y = new float[]{111f,77f,27f,-15f,-59f,-97f};
    
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
        
        h1w1_go.SetActive(true);
        h1w2_go.SetActive(false);
        h1w3_go.SetActive(false);
        h1w4_go.SetActive(false);
        h1w5_go.SetActive(false);
        h2w1_go.SetActive(false);
        h2w2_go.SetActive(false);
        h2w3_go.SetActive(false);
        h2w4_go.SetActive(false);
        h2w5_go.SetActive(false);
        h3w1_go.SetActive(false);
        h3w2_go.SetActive(false);
        h3w3_go.SetActive(false);
        h3w4_go.SetActive(false);
        h3w5_go.SetActive(false);
        h4w1_go.SetActive(false);
        h4w2_go.SetActive(false);
        h4w3_go.SetActive(false);
        h4w4_go.SetActive(false);
        h4w5_go.SetActive(false);
        h5w1_go.SetActive(false);
        h5w2_go.SetActive(false);
        h5w3_go.SetActive(false);
        h5w4_go.SetActive(false);
        h5w5_go.SetActive(false);
        
        h1click();
        w1click();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void h1click()
    {
        selectedHero = 1;
        indicate();
        bar1.GetComponent<Image>().sprite = spriteList[h1upgrade];
        switch (h1weapon)
        {
            case 5:
                bar2.GetComponent<Image>().sprite = spriteList[h1w5upgrade];
                break;
            case 4:
                bar2.GetComponent<Image>().sprite = spriteList[h1w4upgrade];
                break;
            case 3:
                bar2.GetComponent<Image>().sprite = spriteList[h1w3upgrade];
                break;
            case 2:
                bar2.GetComponent<Image>().sprite = spriteList[h1w2upgrade];
                break;
            case 1:
                bar2.GetComponent<Image>().sprite = spriteList[h1w1upgrade];
                break;
            case 0:
                bar2.GetComponent<Image>().sprite = spriteList[12];
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
        int bar2upgradeprice = 0;
        switch (h1weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w1upgradecost[h1w1upgrade];
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w2upgradecost[h1w2upgrade];
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w3upgradecost[h1w3upgrade];
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w4upgradecost[h1w4upgrade];
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w5upgradecost[h1w5upgrade];
                break;
        }
        bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h1upgrade].ToString()+" xul");
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+bar2upgradeprice.ToString()+" xul");
        
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
                h2_go.transform.position = new Vector3(h2_go.transform.position.x, 0, h2_go.transform.position.z);
                selectedHero = 2;
                w0click();
            } else {
                return;
            }
        }
        selectedHero = 2;
        indicate();
        bar1.GetComponent<Image>().sprite = spriteList[h2upgrade];
        switch (h2weapon)
        {
            case 5:
                bar2.GetComponent<Image>().sprite = spriteList[h2w5upgrade];
                break;
            case 4:
                bar2.GetComponent<Image>().sprite = spriteList[h2w4upgrade];
                break;
            case 3:
                bar2.GetComponent<Image>().sprite = spriteList[h2w3upgrade];
                break;
            case 2:
                bar2.GetComponent<Image>().sprite = spriteList[h2w2upgrade];
                break;
            case 1:
                bar2.GetComponent<Image>().sprite = spriteList[h2w1upgrade];
                break;
            case 0:
                bar2.GetComponent<Image>().sprite = spriteList[12];
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
        int bar2upgradeprice = 0;
        switch (h2weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w1upgradecost[h2w1upgrade];
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w2upgradecost[h2w2upgrade];
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w3upgradecost[h2w3upgrade];
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w4upgradecost[h2w4upgrade];
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w5upgradecost[h2w5upgrade];
                break;
        }
        bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h2upgrade].ToString()+" xul");
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+bar2upgradeprice.ToString()+" xul");
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
                h3_go.transform.position = new Vector3(h3_go.transform.position.x, 0, h3_go.transform.position.z);
                selectedHero = 3;
                w0click();
            } else {
                return;
            }
        }
        selectedHero = 3;
        indicate();
        bar1.GetComponent<Image>().sprite = spriteList[h3upgrade];
        switch (h3weapon)
        {
            case 5:
                bar2.GetComponent<Image>().sprite = spriteList[h3w5upgrade];
                break;
            case 4:
                bar2.GetComponent<Image>().sprite = spriteList[h3w4upgrade];
                break;
            case 3:
                bar2.GetComponent<Image>().sprite = spriteList[h3w3upgrade];
                break;
            case 2:
                bar2.GetComponent<Image>().sprite = spriteList[h3w2upgrade];
                break;
            case 1:
                bar2.GetComponent<Image>().sprite = spriteList[h3w1upgrade];
                break;
            case 0:
                bar2.GetComponent<Image>().sprite = spriteList[12];
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
        int bar2upgradeprice = 0;
        switch (h3weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w1upgradecost[h3w1upgrade];
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w2upgradecost[h3w2upgrade];
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w3upgradecost[h3w3upgrade];
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w4upgradecost[h3w4upgrade];
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w5upgradecost[h3w5upgrade];
                break;
        }
        bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h3upgrade].ToString()+" xul");
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+bar2upgradeprice.ToString()+" xul");
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
                h4_go.transform.position = new Vector3(h4_go.transform.position.x, 0, h4_go.transform.position.z);
                selectedHero = 4;
                w0click();
            } else {
                return;
            }
        }
        selectedHero = 4;
        indicate();
        bar1.GetComponent<Image>().sprite = spriteList[h4upgrade];
        switch (h4weapon)
        {
            case 5:
                bar2.GetComponent<Image>().sprite = spriteList[h4w5upgrade];
                break;
            case 4:
                bar2.GetComponent<Image>().sprite = spriteList[h4w4upgrade];
                break;
            case 3:
                bar2.GetComponent<Image>().sprite = spriteList[h4w3upgrade];
                break;
            case 2:
                bar2.GetComponent<Image>().sprite = spriteList[h4w2upgrade];
                break;
            case 1:
                bar2.GetComponent<Image>().sprite = spriteList[h4w1upgrade];
                break;
            case 0:
                bar2.GetComponent<Image>().sprite = spriteList[12];
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
        int bar2upgradeprice = 0;
        switch (h4weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w1upgradecost[h4w1upgrade];
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w2upgradecost[h4w2upgrade];
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w3upgradecost[h4w3upgrade];
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w4upgradecost[h4w4upgrade];
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w5upgradecost[h4w5upgrade];
                break;
        }
        bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h4upgrade].ToString()+" xul");
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+bar2upgradeprice.ToString()+" xul");
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
                h5_go.transform.position = new Vector3(h5_go.transform.position.x, 0, h5_go.transform.position.z);
                selectedHero = 5;
                w0click();
            } else {
                return;
            }
        }
        selectedHero = 5;
        indicate();
        bar1.GetComponent<Image>().sprite = spriteList[h5upgrade];
        switch (h5weapon)
        {
            case 5:
                bar2.GetComponent<Image>().sprite = spriteList[h5w5upgrade];
                break;
            case 4:
                bar2.GetComponent<Image>().sprite = spriteList[h5w4upgrade];
                break;
            case 3:
                bar2.GetComponent<Image>().sprite = spriteList[h5w3upgrade];
                break;
            case 2:
                bar2.GetComponent<Image>().sprite = spriteList[h5w2upgrade];
                break;
            case 1:
                bar2.GetComponent<Image>().sprite = spriteList[h5w1upgrade];
                break;
            case 0:
                bar2.GetComponent<Image>().sprite = spriteList[12];
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
        int bar2upgradeprice = 0;
        switch (h5weapon)
        {
            case 0:
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                break;
            case 1:
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w1upgradecost[h5w1upgrade];
                break;
            case 2:
                button_weapon_2.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w2upgradecost[h5w2upgrade];
                break;
            case 3:
                button_weapon_3.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w3upgradecost[h5w3upgrade];
                break;
            case 4:
                button_weapon_4.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w4upgradecost[h5w4upgrade];
                break;
            case 5:
                button_weapon_5.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
                bar2upgradeprice = w5upgradecost[h5w5upgrade];
                break;
        }
        bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h5upgrade].ToString()+" xul");
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+bar2upgradeprice.ToString()+" xul");
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
                //h1 can multitask
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
                //patrol
                h2w1_go.SetActive(false);
                h2w2_go.SetActive(false);
                h2w3_go.SetActive(false);
                h2w4_go.SetActive(false);
                h2w5_go.SetActive(false);
                h2_go.GetComponent<Patrol>().enabel = true;
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
                //patrol
                h3w1_go.SetActive(false);
                h3w2_go.SetActive(false);
                h3w3_go.SetActive(false);
                h3w4_go.SetActive(false);
                h3w5_go.SetActive(false);
                h3_go.GetComponent<Patrol>().enabel = true;
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
                //patrol
                h4w1_go.SetActive(false);
                h4w2_go.SetActive(false);
                h4w3_go.SetActive(false);
                h4w4_go.SetActive(false);
                h4w5_go.SetActive(false);
                h4_go.GetComponent<Patrol>().enabel = true;
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
                //patrol
                h5w1_go.SetActive(false);
                h5w2_go.SetActive(false);
                h5w3_go.SetActive(false);
                h5w4_go.SetActive(false);
                h5w5_go.SetActive(false);
                h5_go.GetComponent<Patrol>().enabel = true;
                break;
            default:
                break;
        }
        button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
        bar2.GetComponent<Image>().sprite = spriteList[12];
        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
        indicate();
    }

    public void w1click()
    {
        switch (selectedHero)
        {
            case 1:
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h1w1upgrade].ToString()+" xul");
                h1w1_go.SetActive(true);
                h1w2_go.SetActive(false);
                h1w3_go.SetActive(false);
                h1w4_go.SetActive(false);
                h1w5_go.SetActive(false);
                h1weapon = 1;
                break;
            case 2:
                if (!h2w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h2w1bought = true;
                        Currency.xul -= w1cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h2w1upgrade].ToString()+" xul");
                h2w1_go.SetActive(true);
                h2w2_go.SetActive(false);
                h2w3_go.SetActive(false);
                h2w4_go.SetActive(false);
                h2w5_go.SetActive(false);
                h2weapon = 1;
                h2_go.GetComponent<Patrol>().enabel = false;
                break;
            case 3:
                if (!h3w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h3w1bought = true;
                        Currency.xul -= w1cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h3w1upgrade].ToString()+" xul");
                h3w1_go.SetActive(true);
                h3w2_go.SetActive(false);
                h3w3_go.SetActive(false);
                h3w4_go.SetActive(false);
                h3w5_go.SetActive(false);
                h3weapon = 1;
                h3_go.GetComponent<Patrol>().enabel = false;
                break;
            case 4:
                if (!h4w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h4w1bought = true;
                        Currency.xul -= w1cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h4w1upgrade].ToString()+" xul");
                h4w1_go.SetActive(true);
                h4w2_go.SetActive(false);
                h4w3_go.SetActive(false);
                h4w4_go.SetActive(false);
                h4w5_go.SetActive(false);
                h4weapon = 1;
                h4_go.GetComponent<Patrol>().enabel = false;
                break;
            case 5:
                if (!h5w1bought)
                {
                    if (Currency.xul >= w1cost)
                    {
                        h5w1bought = true;
                        Currency.xul -= w1cost;
                        if (!AchievementHandler.a2trigger){
                            AchievementHandler.a2trigger = true;
                        }
                    } else {
                        return;
                    }
                }
                button_patrol.GetComponentInChildren<TextMeshProUGUI>().SetText("unlocked");
                button_weapon_1.GetComponentInChildren<TextMeshProUGUI>().SetText("active");
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
                bar2.GetComponent<Image>().sprite = spriteList[h5w1upgrade];
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h5w1upgrade].ToString()+" xul");
                h5w1_go.SetActive(true);
                h5w2_go.SetActive(false);
                h5w3_go.SetActive(false);
                h5w4_go.SetActive(false);
                h5w5_go.SetActive(false);
                h5weapon = 1;
                h5_go.GetComponent<Patrol>().enabel = false;
                break;
            default:
                break;
        }
        indicate();
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h1w2upgrade].ToString()+" xul");
                h1w1_go.SetActive(false);
                h1w2_go.SetActive(true);
                h1w3_go.SetActive(false);
                h1w4_go.SetActive(false);
                h1w5_go.SetActive(false);
                h1weapon = 2;
                break;
            case 2:
                if (!h2w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h2w2bought = true;
                        Currency.xul -= w2cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h2w2upgrade].ToString()+" xul");
                h2w1_go.SetActive(false);
                h2w2_go.SetActive(true);
                h2w3_go.SetActive(false);
                h2w4_go.SetActive(false);
                h2w5_go.SetActive(false);
                h2weapon = 2;
                h2_go.GetComponent<Patrol>().enabel = false;
                break;
            case 3:
                if (!h3w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h3w2bought = true;
                        Currency.xul -= w2cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h3w2upgrade].ToString()+" xul");
                h3w1_go.SetActive(false);
                h3w2_go.SetActive(true);
                h3w3_go.SetActive(false);
                h3w4_go.SetActive(false);
                h3w5_go.SetActive(false);
                h3weapon = 2;
                h3_go.GetComponent<Patrol>().enabel = false;
                break;
            case 4:
                if (!h4w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h4w2bought = true;
                        Currency.xul -= w2cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h4w2upgrade].ToString()+" xul");
                h4w1_go.SetActive(false);
                h4w2_go.SetActive(true);
                h4w3_go.SetActive(false);
                h4w4_go.SetActive(false);
                h4w5_go.SetActive(false);
                h4weapon = 2;
                h4_go.GetComponent<Patrol>().enabel = false;
                break;
            case 5:
                if (!h5w2bought)
                {
                    if (Currency.xul >= w2cost)
                    {
                        h5w2bought = true;
                        Currency.xul -= w2cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h5w2upgrade].ToString()+" xul");
                h5w1_go.SetActive(false);
                h5w2_go.SetActive(true);
                h5w3_go.SetActive(false);
                h5w4_go.SetActive(false);
                h5w5_go.SetActive(false);
                h5weapon = 2;
                h5_go.GetComponent<Patrol>().enabel = false;
                break;
            default:
                break;
        }
        indicate();
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h1w3upgrade].ToString()+" xul");
                h1w1_go.SetActive(false);
                h1w2_go.SetActive(false);
                h1w3_go.SetActive(true);
                h1w4_go.SetActive(false);
                h1w5_go.SetActive(false);
                h1weapon = 3;
                break;
            case 2:
                if (!h2w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h2w3bought = true;
                        Currency.xul -= w3cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h2w3upgrade].ToString()+" xul");
                h2w1_go.SetActive(false);
                h2w2_go.SetActive(false);
                h2w3_go.SetActive(true);
                h2w4_go.SetActive(false);
                h2w5_go.SetActive(false);
                h2weapon = 3;
                h2_go.GetComponent<Patrol>().enabel = false;
                break;
            case 3:
                if (!h3w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h3w3bought = true;
                        Currency.xul -= w3cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h3w3upgrade].ToString()+" xul");
                h3w1_go.SetActive(false);
                h3w2_go.SetActive(false);
                h3w3_go.SetActive(true);
                h3w4_go.SetActive(false);
                h3w5_go.SetActive(false);
                h3weapon = 3;
                h3_go.GetComponent<Patrol>().enabel = false;
                break;
            case 4:
                if (!h4w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h4w3bought = true;
                        Currency.xul -= w3cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h4w3upgrade].ToString()+" xul");
                h4w1_go.SetActive(false);
                h4w2_go.SetActive(false);
                h4w3_go.SetActive(true);
                h4w4_go.SetActive(false);
                h4w5_go.SetActive(false);
                h4weapon = 3;
                h4_go.GetComponent<Patrol>().enabel = false;
                break;
            case 5:
                if (!h5w3bought)
                {
                    if (Currency.xul >= w3cost)
                    {
                        h5w3bought = true;
                        Currency.xul -= w3cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h5w3upgrade].ToString()+" xul");
                h5w1_go.SetActive(false);
                h5w2_go.SetActive(false);
                h5w3_go.SetActive(true);
                h5w4_go.SetActive(false);
                h5w5_go.SetActive(false);
                h5weapon = 3;
                h5_go.GetComponent<Patrol>().enabel = false;
                break;
            default:
                break;
        }
        indicate();
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h1w4upgrade].ToString()+" xul");
                h1w1_go.SetActive(false);
                h1w2_go.SetActive(false);
                h1w3_go.SetActive(false);
                h1w4_go.SetActive(true);
                h1w5_go.SetActive(false);
                h1weapon = 4;
                break;
            case 2:
                if (!h2w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h2w4bought = true;
                        Currency.xul -= w4cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h2w4upgrade].ToString()+" xul");
                h2w1_go.SetActive(false);
                h2w2_go.SetActive(false);
                h2w3_go.SetActive(false);
                h2w4_go.SetActive(true);
                h2w5_go.SetActive(false);
                h2weapon = 4;
                h2_go.GetComponent<Patrol>().enabel = false;
                break;
            case 3:
                if (!h3w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h3w4bought = true;
                        Currency.xul -= w4cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h3w4upgrade].ToString()+" xul");
                h3w1_go.SetActive(false);
                h3w2_go.SetActive(false);
                h3w3_go.SetActive(false);
                h3w4_go.SetActive(true);
                h3w5_go.SetActive(false);
                h3weapon = 4;
                h3_go.GetComponent<Patrol>().enabel = false;
                break;
            case 4:
                if (!h4w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h4w4bought = true;
                        Currency.xul -= w4cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h4w4upgrade].ToString()+" xul");
                h4w1_go.SetActive(false);
                h4w2_go.SetActive(false);
                h4w3_go.SetActive(false);
                h4w4_go.SetActive(true);
                h4w5_go.SetActive(false);
                h4weapon = 4;
                h4_go.GetComponent<Patrol>().enabel = false;
                break;
            case 5:
                if (!h5w4bought)
                {
                    if (Currency.xul >= w4cost)
                    {
                        h5w4bought = true;
                        Currency.xul -= w4cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h5w4upgrade].ToString()+" xul");
                h5w1_go.SetActive(false);
                h5w2_go.SetActive(false);
                h5w3_go.SetActive(false);
                h5w4_go.SetActive(true);
                h5w5_go.SetActive(false);
                h5weapon = 4;
                h5_go.GetComponent<Patrol>().enabel = false;
                break;
            default:
                break;
        }
        indicate();
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h1w5upgrade].ToString()+" xul");
                h1w1_go.SetActive(false);
                h1w2_go.SetActive(false);
                h1w3_go.SetActive(false);
                h1w4_go.SetActive(false);
                h1w5_go.SetActive(true);
                h1weapon = 5;
                break;
            case 2:
                if (!h2w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h2w5bought = true;
                        Currency.xul -= w5cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h2w5upgrade].ToString()+" xul");
                h2w1_go.SetActive(false);
                h2w2_go.SetActive(false);
                h2w3_go.SetActive(false);
                h2w4_go.SetActive(false);
                h2w5_go.SetActive(true);
                h2weapon = 5;
                h2_go.GetComponent<Patrol>().enabel = false;
                break;
            case 3:
                if (!h3w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h3w5bought = true;
                        Currency.xul -= w5cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h3w5upgrade].ToString()+" xul");
                h3w1_go.SetActive(false);
                h3w2_go.SetActive(false);
                h3w3_go.SetActive(false);
                h3w4_go.SetActive(false);
                h3w5_go.SetActive(true);
                h3weapon = 5;
                h3_go.GetComponent<Patrol>().enabel = false;
                break;
            case 4:
                if (!h4w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h4w5bought = true;
                        Currency.xul -= w5cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h4w5upgrade].ToString()+" xul");
                h4w1_go.SetActive(false);
                h4w2_go.SetActive(false);
                h4w3_go.SetActive(false);
                h4w4_go.SetActive(false);
                h4w5_go.SetActive(true);
                h4weapon = 5;
                h4_go.GetComponent<Patrol>().enabel = false;
                break;
            case 5:
                if (!h5w5bought)
                {
                    if (Currency.xul >= w5cost)
                    {
                        h5w5bought = true;
                        Currency.xul -= w5cost;
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
                bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h5w5upgrade].ToString()+" xul");
                h5w1_go.SetActive(false);
                h5w2_go.SetActive(false);
                h5w3_go.SetActive(false);
                h5w4_go.SetActive(false);
                h5w5_go.SetActive(true);
                h5weapon = 5;
                h5_go.GetComponent<Patrol>().enabel = false;
                break;
            default:
                break;
        }
        indicate();
    }

    void indicate()
    {
        Vector3 indicatorposition = heroindicator.GetComponent<RectTransform>().anchoredPosition;
        indicatorposition.y = indicator_y[selectedHero-1];
        heroindicator.GetComponent<RectTransform>().anchoredPosition = indicatorposition;

        Vector3 indicatorposition2 = weaponindicator.GetComponent<RectTransform>().anchoredPosition;
        Debug.Log(indicatorposition2);
        switch (selectedHero)
        {
            case 1:
                indicatorposition2.y = indicator_y[h1weapon];
                break;
            case 2:
                indicatorposition2.y = indicator_y[h2weapon];
                break;
            case 3:
                indicatorposition2.y = indicator_y[h3weapon];
                break;
            case 4:
                indicatorposition2.y = indicator_y[h4weapon];
                break;
            case 5:
                indicatorposition2.y = indicator_y[h5weapon];
                break;
        }
        Debug.Log(indicatorposition2);
        weaponindicator.GetComponent<RectTransform>().anchoredPosition = indicatorposition2;
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
                bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h1upgrade].ToString()+" xul");
                break;
            case 2:
                if (Currency.xul >= heroupgradecost[h2upgrade])
                {
                    Currency.xul -= heroupgradecost[h2upgrade];
                    h2upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h2upgrade];
                bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h2upgrade].ToString()+" xul");
                break;
            case 3:
                if (Currency.xul >= heroupgradecost[h3upgrade])
                {
                    Currency.xul -= heroupgradecost[h3upgrade];
                    h3upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h3upgrade];
                bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h3upgrade].ToString()+" xul");
                break;
            case 4:
                if (Currency.xul >= heroupgradecost[h4upgrade])
                {
                    Currency.xul -= heroupgradecost[h4upgrade];
                    h4upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h4upgrade];
                bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h4upgrade].ToString()+" xul");
                break;
            case 5:
                if (Currency.xul >= heroupgradecost[h5upgrade])
                {
                    Currency.xul -= heroupgradecost[h5upgrade];
                    h5upgrade +=1;
                }
                bar1.GetComponent<Image>().sprite = spriteList[h5upgrade];
                bar1.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+heroupgradecost[h5upgrade].ToString()+" xul");
                break;
            default:
                Debug.Log(selectedHero);
                break;
        }
        updateDamage();
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h1w1upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h1w2upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h1w3upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h1w4upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h1w5upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h2w1upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h2w2upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h2w3upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h2w4upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h2w5upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h3w1upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h3w2upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h3w3upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h3w4upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h3w5upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h4w1upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h4w2upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h4w3upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h4w4upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h4w5upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: 0 xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w1upgradecost[h5w1upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w2upgradecost[h5w2upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w3upgradecost[h5w3upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w4upgradecost[h5w4upgrade].ToString()+" xul");
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
                        bar2.GetComponentInChildren<TextMeshProUGUI>().SetText("upgrade cost: "+w5upgradecost[h5w5upgrade].ToString()+" xul");
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
        updateDamage();
    }

    private int[] gunbasedamage = new int[]{1,5,20,100,200};
    //dmg formula: dmg = basedamage * (1+#heroupgrade+#weaponupgrade)^0.5
    private double upgradepowerfactor = 1.0;

    void updateDamage()
    {

        // Debug.Log(h1w1_go.GetComponent<FireWeapon>().damage);

        h1w1_go.GetComponent<FireWeapon>().damage = (int)Math.Round(gunbasedamage[0]*Math.Pow(1+h1upgrade+h1w1upgrade,upgradepowerfactor));
        h1w2_go.GetComponent<FireWeapon2>().damage = (int)Math.Round(gunbasedamage[1]*Math.Pow(1+h1upgrade+h1w2upgrade,upgradepowerfactor));
        h1w3_go.GetComponent<FireWeapon3>().damage = (int)Math.Round(gunbasedamage[2]*Math.Pow(1+h1upgrade+h1w3upgrade,upgradepowerfactor));
        h1w4_go.GetComponent<FireWeapon4>().damage = (int)Math.Round(gunbasedamage[3]*Math.Pow(1+h1upgrade+h1w4upgrade,upgradepowerfactor));
        h1w5_go.GetComponent<FireWeapon5>().damage = (int)Math.Round(gunbasedamage[4]*Math.Pow(1+h1upgrade+h1w5upgrade,upgradepowerfactor));
        
        h2w1_go.GetComponent<AutoFireWeapon1>().damage = (int)Math.Round(gunbasedamage[0]*Math.Pow(1+h1upgrade+h1w1upgrade,upgradepowerfactor));
        h2w2_go.GetComponent<AutoFireWeapon2>().damage = (int)Math.Round(gunbasedamage[1]*Math.Pow(1+h1upgrade+h1w2upgrade,upgradepowerfactor));
        h2w3_go.GetComponent<AutoFireWeapon3>().damage = (int)Math.Round(gunbasedamage[2]*Math.Pow(1+h1upgrade+h1w3upgrade,upgradepowerfactor));
        h2w4_go.GetComponent<AutoFireWeapon4>().damage = (int)Math.Round(gunbasedamage[3]*Math.Pow(1+h1upgrade+h1w4upgrade,upgradepowerfactor));
        h2w5_go.GetComponent<AutoFireWeapon5>().damage = (int)Math.Round(gunbasedamage[4]*Math.Pow(1+h1upgrade+h1w5upgrade,upgradepowerfactor));
        
        h3w1_go.GetComponent<AutoFireWeapon1>().damage = (int)Math.Round(gunbasedamage[0]*Math.Pow(1+h1upgrade+h1w1upgrade,upgradepowerfactor));
        h3w2_go.GetComponent<AutoFireWeapon2>().damage = (int)Math.Round(gunbasedamage[1]*Math.Pow(1+h1upgrade+h1w2upgrade,upgradepowerfactor));
        h3w3_go.GetComponent<AutoFireWeapon3>().damage = (int)Math.Round(gunbasedamage[2]*Math.Pow(1+h1upgrade+h1w3upgrade,upgradepowerfactor));
        h3w4_go.GetComponent<AutoFireWeapon4>().damage = (int)Math.Round(gunbasedamage[3]*Math.Pow(1+h1upgrade+h1w4upgrade,upgradepowerfactor));
        h3w5_go.GetComponent<AutoFireWeapon5>().damage = (int)Math.Round(gunbasedamage[4]*Math.Pow(1+h1upgrade+h1w5upgrade,upgradepowerfactor));
        
        h4w1_go.GetComponent<AutoFireWeapon1>().damage = (int)Math.Round(gunbasedamage[0]*Math.Pow(1+h1upgrade+h1w1upgrade,upgradepowerfactor));
        h4w2_go.GetComponent<AutoFireWeapon2>().damage = (int)Math.Round(gunbasedamage[1]*Math.Pow(1+h1upgrade+h1w2upgrade,upgradepowerfactor));
        h4w3_go.GetComponent<AutoFireWeapon3>().damage = (int)Math.Round(gunbasedamage[2]*Math.Pow(1+h1upgrade+h1w3upgrade,upgradepowerfactor));
        h4w4_go.GetComponent<AutoFireWeapon4>().damage = (int)Math.Round(gunbasedamage[3]*Math.Pow(1+h1upgrade+h1w4upgrade,upgradepowerfactor));
        h4w5_go.GetComponent<AutoFireWeapon5>().damage = (int)Math.Round(gunbasedamage[4]*Math.Pow(1+h1upgrade+h1w5upgrade,upgradepowerfactor));
        
        h5w1_go.GetComponent<AutoFireWeapon1>().damage = (int)Math.Round(gunbasedamage[0]*Math.Pow(1+h1upgrade+h1w1upgrade,upgradepowerfactor));
        h5w2_go.GetComponent<AutoFireWeapon2>().damage = (int)Math.Round(gunbasedamage[1]*Math.Pow(1+h1upgrade+h1w2upgrade,upgradepowerfactor));
        h5w3_go.GetComponent<AutoFireWeapon3>().damage = (int)Math.Round(gunbasedamage[2]*Math.Pow(1+h1upgrade+h1w3upgrade,upgradepowerfactor));
        h5w4_go.GetComponent<AutoFireWeapon4>().damage = (int)Math.Round(gunbasedamage[3]*Math.Pow(1+h1upgrade+h1w4upgrade,upgradepowerfactor));
        h5w5_go.GetComponent<AutoFireWeapon5>().damage = (int)Math.Round(gunbasedamage[4]*Math.Pow(1+h1upgrade+h1w5upgrade,upgradepowerfactor));

        // Debug.Log(h1w1_go.GetComponent<FireWeapon>().damage);
        
    }

}
