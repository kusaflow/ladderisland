using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoreMngr : MonoBehaviour
{
    public TMPro.TextMeshProUGUI score;

    private void Start() {
        score = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ladder.score.ToString();
    }
}
