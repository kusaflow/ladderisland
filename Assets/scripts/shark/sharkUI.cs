using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sharkUI : MonoBehaviour
{
    public Scrollbar bar;
    public GameObject shark;
    public GameObject player;
    

    // Update is called once per frame
    void Update()
    {
        float dis = player.transform.position.x - shark.transform.position.x;
        dis = Mathf.Abs(dis);
        dis = dis/40.0f;
        dis = Mathf.Clamp(dis, 0, 1);

        bar.value = dis;
        


    }
}
