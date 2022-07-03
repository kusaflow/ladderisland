using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPowerPrice : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public bool isMeat = false;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        if (isMeat)
            text.text = globalV.meat_PowerCost.ToString();
        else
            text.text = globalV.magnet_PowerCost.ToString();
        
    }
}
