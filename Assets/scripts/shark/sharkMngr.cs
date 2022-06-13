using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkMngr : MonoBehaviour
{

    public static float sharkSpeed = 2;

    public GameObject player;
    public ladder lad;
    


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
        if (!globalV.isDead){
            //Debug.Log(globalV.isDead);
            Vector3 SFPos = transform.position;
            SFPos.x += sharkSpeed * Time.deltaTime;
            transform.position = SFPos;
        }
    }


}
