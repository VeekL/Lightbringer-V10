using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopToggle : MonoBehaviour
{

    public GameObject go;
    private bool ShopEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        go.SetActive(ShopEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab") || Input.GetButtonDown("Jump"))
        {
            ShopEnabled = !ShopEnabled;
            go.SetActive(ShopEnabled);
        }
    }
}
