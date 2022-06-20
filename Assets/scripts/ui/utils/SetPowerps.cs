using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPowerps : MonoBehaviour
{
     public TMPro.TextMeshProUGUI text;
     public bool chicken = true;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
            
    }

    private void Update() {
        if (chicken)
            text.text = globalV.ChickenPower.ToString();
        else
            text.text = globalV.CheatPower.ToString();
        
    }
}
