using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XulBar : MonoBehaviour
{
    public Image currentXulbar;
    public Text ratioText;
   
    private float maxCurrency = 1000000;

    private void Start()
    {
        UpdateXulbar();
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
