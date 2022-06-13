using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreMngr : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;
    public ladder lad;
    

    // Update is called once per frame
    void Update()
    {
        score.text = lad.score.ToString();
    }
}
