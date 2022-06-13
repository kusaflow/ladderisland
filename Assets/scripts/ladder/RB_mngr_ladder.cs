using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_mngr_ladder : MonoBehaviour
{

    public GameObject blue;

    ladder lad;

    private void Start() {
        lad = GetComponent<ladder>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = blue.transform.localPosition;
        //pos.x += lad.targetLocation * Mathf.Sin(Mathf.Abs(lad.ladRot)*Mathf.Deg2Rad);
        //pos.y = transform.position.y + (transform.localScale.x * lad.sr.size.y);
        //pos.y = lad.targetLocation * blue.transform.localScale.y;
        //Debug.Log(Mathf.Abs(lad.ladRot) + "----" + Mathf.Cos(Mathf.Abs(lad.ladRot)*Mathf.Deg2Rad));
        pos.y = lad.sr.size.y;
        //Debug.Log(pos.y);
        blue.transform.localPosition = pos;
        
    }
}
