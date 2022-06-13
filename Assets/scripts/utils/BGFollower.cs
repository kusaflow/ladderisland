using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGFollower : MonoBehaviour
{
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 BGpos = transform.position;
        BGpos.x = cam.transform.position.x;
        transform.position = BGpos;
    }
}
