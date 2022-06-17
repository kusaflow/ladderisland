  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMngr : MonoBehaviour
{
    public k_lvlMngr lvlMngr;
    public ladder lad;
    float TargetXpos = 0;
    
    private Camera cam;

    public float CamMvmntSpeed = 12;
    public float y_CamMvmntSpeed = 1.5f;
    public float y_Down_CamMvmntSpeed = 12;
    public float CamSizeRate = 1.5f;
    public float ZoomOUT = 1.5f;

    private void Start() {
        cam = GetComponent<Camera>();
    }


    // Update is called once per frame
    //-3.08
    void Update()
    {
        if (GameMenuMngr.isInPlayMode){
            translate();
            ZoomMngr();
            YposMngr();
        }

    }

    void ZoomMngr(){
        if (lad.isTouchedDown && !globalV.isDead){
           cam.orthographicSize += CamSizeRate * Time.deltaTime;
           cam.orthographicSize = Mathf.Clamp(cam.orthographicSize,
                                                                            3.2f, 9);
        } 
        if (lad.resetCamera){
            //Debug.Log(cam.orthographicSize);
            if (cam.orthographicSize < 3.2f)
                cam.orthographicSize += 8 * Time.deltaTime;
            else{
                cam.orthographicSize -= 15 * Time.deltaTime;
                cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, 3.2f, 9);
            }
        } 
    }

    void translate(){
        TargetXpos = lvlMngr.CamFocusIsland + 3.5f;
        //Debug.Log(TargetXpos);
        //Debug.Log(lvlMngr.Q_island.Peek().transform.position);
        
        if (transform.position.x < TargetXpos){
            Vector3 newpos = transform.position;
            newpos.x += CamMvmntSpeed * Time.deltaTime;
            transform.position = newpos;
        }
        
        if (transform.position.x > TargetXpos){
            Vector3 newpos = transform.position;
            newpos.x -= CamMvmntSpeed * Time.deltaTime;
            transform.position = newpos;
        }
    }

    void YposMngr(){
        //-1.72
        Vector3 campos = transform.position;
        
        if (lad.isTouchedDown && !globalV.isDead){
            if (campos.y < 4)
                campos.y += (y_CamMvmntSpeed)*Time.deltaTime;
            
        } 
        if (lad.resetCamera){
            if (campos.y > -1.72)
            campos.y -= (y_Down_CamMvmntSpeed)*Time.deltaTime;
            if (campos.y < -1.72)
            campos.y += (y_Down_CamMvmntSpeed)*Time.deltaTime;
        } 

        
        transform.position = campos;
        
    }


}
