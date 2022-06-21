using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    public static bool isFree = true;
    public animMngr mainPlayer;
    public k_lvlMngr lvlMngr;
    public GameObject tmpobj;
    

    public bool isTouchedDown = false;
    bool b_ladderIncDone = false;
    bool b_afterMathCalled = false;

    public bool resetCamera = true;
    bool ladderRot_isP_dead = false;

    float timerforinputtowork = 40;
    
    
    public SpriteRenderer sr;
    public float ladRot = 0;
    public float sizeIncRate = 60; 
    public float ladRotSpeed = 10;
 
    public float targetLocation = 0;
    
    public float CamSizeRate = 100; 

     public GameObject sharkFinn;

     public static int score;

     bool canTouchscreen = true;
    /*
    2.1 at h 10
    -0.85663 at h 50 


    2.95663 -- 40

    */




    // Start is called before the first frame update
    void Start()
    {
         sr = GetComponent<SpriteRenderer>();
         score = 0;
         isFree = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameMenuMngr.isInPlayMode){
            return;
        }
        k_input();
        ladderUpdate();
        //CameraMngr();
        if (!b_afterMathCalled && b_ladderIncDone){
            aftermath();
            b_afterMathCalled = true;
        }

        targetLocation = transform.position.x + (transform.localScale.x * sr.size.y);
        tmpobj.transform.position = new Vector3(targetLocation, -3.862f, 0);

        
    }

    void k_input(){
        if (!globalV.isDead && timerforinputtowork >= 20){
            if (Input.GetMouseButtonDown(0) && canTouchscreen && Input.mousePosition.y <= Screen.height/1.26f ){
                //Debug.Log("ddddddddd");
                isTouchedDown = true;
                resetCamera = false;
            } 
            if (Input.GetMouseButtonUp(0) && isTouchedDown){
                isTouchedDown = false;
                b_ladderIncDone = true;
                canTouchscreen = false;
                isFree = false;
                mainPlayer.anim.Play(globalV.CurrentAvatar+ "_Die");
            }
        }else{
            timerforinputtowork = Mathf.Clamp(timerforinputtowork+10*Time.deltaTime, 0, 60);
        }

    }

    void CameraMngr(){
        if (isTouchedDown && !globalV.isDead){
            Camera.allCameras[0].orthographicSize += CamSizeRate * Time.deltaTime;
            Camera.allCameras[0].orthographicSize = Mathf.Clamp(Camera.allCameras[0].orthographicSize,
                                                                            3.2f, 15);
        } 
        if (resetCamera){
            Camera.allCameras[0].orthographicSize -= 15 * Time.deltaTime;
            Camera.allCameras[0].orthographicSize = Mathf.Clamp(Camera.allCameras[0].orthographicSize,
                                                                            3.2f, 15);
        } 
        
    }

    void ladderUpdate(){
        if (isTouchedDown && !b_ladderIncDone){
            float sr_y = sr.size.y +sizeIncRate*Time.deltaTime;
            sr_y = Mathf.Clamp(sr_y, 0, 300);
            sr.size = new Vector2(sr.size.x, sr_y);
        }

        if (b_ladderIncDone){
            ladRot -= ladRotSpeed * Time.deltaTime; 
            ladRot = Mathf.Clamp(ladRot,ladderRot_isP_dead ? -150 : -90, 0);
            transform.rotation = Quaternion.Euler(0,0,ladRot);

        }
    }

    void aftermath(){
        targetLocation = transform.position.x + (transform.localScale.x * sr.size.y);
        //tmpobj.transform.position = new Vector3(targetLocation, -3.862f, 0);
        islandIdentity[] islandLoc = lvlMngr.Q_island.ToArray();
        int i =0;
        bool died = true;

        //flo lastislandpos = lvlMngr.CamFocusIsland;
        int noIslandsMissed = 0;

        do {
            //Debug.Log(islandLoc[i].gameObject.transform.position);
            if (islandLoc[i].startPos  < targetLocation &&
                islandLoc[i].EndPos > targetLocation ){
                died = false;
            } 
            if (died){
                noIslandsMissed++;
                // //Debug.Log(i);
                // islandIdentity dq = lvlMngr.Q_island.Dequeue();
                // lvlMngr.Q_useless_island.Enqueue(dq.gameObject);
        
                //Destroy(dq.gameObject);
            }
            
            i++;
        }while(i < 5 && died);
        
        ladderRot_isP_dead = died;
        
        lvlMngr.CamFocusIsland = targetLocation;
        ResetValues(died, noIslandsMissed);
        


    }

    void ResetValues(bool died, int noIslandsMissed){
        StartCoroutine(CR_reset(died, noIslandsMissed));
    }

    IEnumerator CR_reset(bool died,int noIslandsMissed){
        yield return new WaitForSeconds(90f/(ladRotSpeed));//////
        //lvlMngr.CamFocusIsland = targetLocation;
         resetCamera = true; 

        Vector3 mainPPos = mainPlayer.gameObject.transform.position;
        mainPPos.x = targetLocation;
        mainPlayer.gameObject.transform.position = mainPPos;
        if (!died)
            mainPlayer.anim.Play(globalV.CurrentAvatar+ "_ReS");
        else
            mainPlayer.anim.Play(globalV.CurrentAvatar+ "_Die");
        
        yield return new WaitForSeconds(0.5f);//////
        
        canTouchscreen = true;
        if (!died){
            for (int i =0; i<noIslandsMissed; i++){        
                islandIdentity dq = lvlMngr.Q_island.Dequeue();
                lvlMngr.Q_useless_island.Enqueue(dq.gameObject);
                score++;
            }

            //Debug.Log("alive");
            //alive
            b_ladderIncDone = false;
            b_afterMathCalled = false;
            
            transform.rotation = Quaternion.Euler(0,0,0);
            sr.size = new Vector2(2.45f ,9.08f);
            Vector3 peekpos = new Vector3(0,-3.862f,0);
            peekpos.x = lvlMngr.Q_island.Peek().transform.position.x;
            transform.position = peekpos;
            ladRot = 0;
            //lvlMngr.CamFocusIsland = lvlMngr.Q_island.Peek().gameObject;
            isFree = true;

            


        }else{
            //dead
            dead();    
            //Vector3 mainPPos = mainPlayer.gameObject.transform.position;
            //mainPPos.x = targetLocation;
            //mainPlayer.gameObject.transform.position = mainPPos;
        }
        //lvlMngr.CamFocusIsland = mainPlayer.gameObject;
    }

    
    //retry
    public void Retry(){
            resetCamera = true; 

            b_ladderIncDone = false;
            b_afterMathCalled = false;
            isTouchedDown = false;
            
            transform.rotation = Quaternion.Euler(0,0,0);
            sr.size = new Vector2(2.45f ,9.08f);
            Vector3 peekpos = new Vector3(0,-3.862f,0);
            peekpos.x = lvlMngr.Q_island.Peek().transform.position.x;
            transform.position = peekpos;
            ladRot = 0;
            //lvlMngr.CamFocusIsland = lvlMngr.Q_island.Peek().gameObject;
            isFree = true;
            globalV.isDead = false;
            ladderRot_isP_dead = false;
            
            Vector3 mainpos = mainPlayer.gameObject.transform.position;
            mainpos.x = peekpos.x;
            mainPlayer.gameObject.transform.position = mainpos;

            lvlMngr.CamFocusIsland = peekpos.x;
            timerforinputtowork = 10;
            mainPlayer.anim.Play(globalV.CurrentAvatar+ "_ReS");

            //shark
            Vector3 finnP = sharkFinn.transform.position;
            finnP.x = mainPlayer.transform.position.x - 30;
            sharkFinn.transform.position = finnP;

            //Camera.allCameras[0].orthographicSize = 3.2f;

    }

    public void dead(){
            //dead
            Debug.Log("dead");
            //lvlMngr.CamFocusIsland = lastislandpos; 
            globalV.isDead = true;
            isTouchedDown = false;
    }
    
}
