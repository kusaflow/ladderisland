using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdPrice : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        text.text = globalV.retryCost.ToString();
    }
}

