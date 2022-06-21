using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheatMngr : MonoBehaviour
{
    public PowerUpMngr power;
    public SpriteRenderer sr;
    // Update is called once per frame
    void Update()
    {
        if (power.isPowerConsumed && !power.isChicken){
            sr.color = new Color(1,0,0,1);
        } else{
            sr.color = new Color(1,0,0,0);    
        }
    }
}
