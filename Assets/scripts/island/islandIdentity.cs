using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandIdentity : MonoBehaviour
{
    public float L_island_length = 1;
    public float R_island_length = 1;
    

    public float startPos = 0;
    public float EndPos = 0;

    private void Start() {
        startPos = transform.position.x - (L_island_length * transform.localScale.x);
        EndPos = transform.position.x + (R_island_length * transform.localScale.x);
    }

}
