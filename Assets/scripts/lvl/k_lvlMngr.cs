using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class k_lvlMngr : MonoBehaviour
{
    /* 
        min dis = 1.9f
        max dis = 9
    */

    float lastIslandPos = 0;
    float nextRender_pos_for_Island = 0;

    public GameObject player;
    

    public islandForLvl island_lvl;
    public Queue<islandIdentity> Q_island = new Queue<islandIdentity>();
    public Queue<GameObject> Q_useless_island = new Queue<GameObject>();

    public float CamFocusIsland;


    // Start is called before the first frame update
    void Start()
    {
        //
        island_lvl = GetComponent<islandForLvl>();
        
    
        islandIdentity frst = Instantiate(island_lvl.islands[0], new Vector3(0,-3.689f,0), new Quaternion());
        Q_island.Enqueue(frst);


        float islandposTemp = 0;
        for (int i =0; i<3; i++){
            islandposTemp += 3.5f;
            islandIdentity lat = Instantiate(island_lvl.islands[0], new Vector3(islandposTemp,-3.689f,0), new Quaternion());
            Q_island.Enqueue(lat);
        }

        CamFocusIsland = frst.gameObject.transform.position.x;
        
        lastIslandPos = islandposTemp;

        DrawNewIslands();

        // for (int i =0; i<20; i++){
        //     Vector3 newpos = new Vector3(0,-3.646f,0);
        //     newpos.x = Random.Range(minSpawnDis, maxSpawnDis);
        //     lastIslandPos += newpos.x;
        //     newpos.x = lastIslandPos;
            
        //     islandIdentity isl = Instantiate(island_lvl.islands[0], newpos, new Quaternion());
        //     Q_island.Enqueue(isl);
        // }
        // nextRender_pos_for_Island = lastIslandPos - 30;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= nextRender_pos_for_Island){
            DrawNewIslands();
        }
        VipeOut();
    }

    void DrawNewIslands(){
        for (int i =0; i<20; i++){
            //Get new Island
            int islandIDX = Random.Range(0, island_lvl.islands.Count);


            Vector3 newpos = new Vector3(0,island_lvl.y_island[islandIDX],0);

            newpos.x = Random.Range(island_lvl.island_min_max[islandIDX].x,island_lvl.island_min_max[islandIDX].y/1.15f);
            lastIslandPos += newpos.x;
            lastIslandPos += island_lvl.R_island[islandIDX];
            newpos.x = lastIslandPos;
            
            islandIdentity isl = Instantiate(island_lvl.islands[islandIDX], newpos, new Quaternion());
            Q_island.Enqueue(isl);
        }
        nextRender_pos_for_Island = lastIslandPos - 50;   
    }

    

    void VipeOut(){
        if (Q_useless_island.Count >= 20){
            GameObject obj = Q_useless_island.Dequeue();
            Destroy(obj);
        }
    }


}
