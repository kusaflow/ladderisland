using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sharkUI : MonoBehaviour
{
    public Scrollbar bar;
    public GameObject shark;
    public GameObject player;

    float pastVal = 0;
    

    // Update is called once per frame
    void Update()
    {
        float dis = player.transform.position.x - shark.transform.position.x;
        dis = Mathf.Abs(dis);
        dis = dis/40.0f;
        dis = Mathf.Clamp(dis, 0, 1);
        
        if (pastVal < dis){
            //Debug.Log(pastVal + "--" + dis);
            dis = Mathf.Lerp(pastVal, dis, 0.05f);
        }
        

        pastVal = dis;
        bar.value = dis;
        


    }
}
