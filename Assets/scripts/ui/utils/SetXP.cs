using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXP : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    // Start is called before the first frame update
    void Update()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        text.text = globalV.XP.ToString();
    }
}

