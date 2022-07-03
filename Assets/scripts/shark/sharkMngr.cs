using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkMngr : MonoBehaviour
{

    public float sharkSpeed = 2;
    public float sharkSpeed_incRate = 2;

    public GameObject player;
    public ladder lad;

    public PowerUpMngr power;
    


    // Update is called once per frame
    void Update()
    {
        if (GameMenuMngr.isInPlayMode)
            Movement();
        //Debug.Log(globalV.isDead);
        //dead
        if (transform.position.x >= player.transform.position.x){
            lad.dead();
        }
    }

    void Movement(){
        if (globalV.isDead){
            return; 
        }
        if (power.isPowerConsumed && power.isChicken)
            return;
        
        Vector3 SFPos = transform.position;
        SFPos.x += sharkSpeed * Time.deltaTime;
        transform.position = SFPos;

        sharkSpeed+=sharkSpeed_incRate * Time.deltaTime;
        
    }


}
