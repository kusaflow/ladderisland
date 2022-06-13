using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cheatonOff : MonoBehaviour
{
    public SpriteRenderer sr;
    public Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.enabled = toggle.isOn;
    }

    
}
