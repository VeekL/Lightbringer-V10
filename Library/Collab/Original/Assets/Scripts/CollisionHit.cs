using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionHit : MonoBehaviour
{

    private Rigidbody2D rb;
    private Collider2D colSelf;
    private ParticleSystem ps;
    public int value = 1;

    public AudioSource CoinAudio;
    public AudioClip PickUpClip;

    public Image currentXulbar;
    public Text ratioText;
    private float maxCurrency = 1000000;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        colSelf = GetComponent<Collider2D>();
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnTriggerEnter2D(Collider2D col){
    //     Debug.Log("collided!");
        
    // }

    void OnTriggerExit2D(Collider2D col){
        // Debug.Log("col exit");
        if (col.gameObject.tag == "Enemy"){
            // Debug.Log("enemy hit!");
            rb.gravityScale = 3f;
            var main = ps.main;
            main.startColor = new Color(0.9f,0.9f,0f,1f);
            ps.Clear(); //restart ps for new color to take effect immediately
            ps.Simulate(5f);
            ps.Play();
            colSelf.isTrigger = false;
            // assign coinclip and play
            CoinAudio.clip = PickUpClip;
            CoinAudio.Play();
        }
        if (col.gameObject.tag == "Wall"){
            // Debug.Log("wall hit!");
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Player" && !colSelf.isTrigger){
            // Debug.Log("player hit!");
            Destroy(gameObject);
            Currency.xul += value;
            UpdateXulbar();
        }
        
    }

    private void UpdateXulbar()
    {
        float ratio = Currency.xul / maxCurrency;
        if (ratio <= 1){
            currentXulbar.rectTransform.localScale = new Vector3(ratio * 2, 1, 1);
            ratioText.text = Mathf.Round((ratio * 100)).ToString() + '%';

        }
        else
        {
            currentXulbar.rectTransform.localScale = new Vector3(2, 1, 1);
            ratioText.text = "100%";
        }



    }
}
