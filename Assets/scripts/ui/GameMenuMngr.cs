using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuMngr : MonoBehaviour
{

    public ladder lad;
    public GameObject Diemenu;
    public GameObject GameEssential_menu;
    public GameObject StartMEnuMngr; 

    public static bool isInPlayMode = false;

    // Start is called before the first frame update
    void Start()
    {
        isInPlayMode = false;
        globalV.isDead = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        startMEnuMngr();
        Diemenu.SetActive(globalV.isDead);
        //Debug.Log(globalV.isDead);
    }

    void startMEnuMngr(){
        GameEssential_menu.SetActive(isInPlayMode && !globalV.isDead);
        StartMEnuMngr.SetActive(!isInPlayMode);
        
        
    }

    public void onretry () {
        if (globalV.retryCost <= globalV.XP){
            globalV.XP -= globalV.retryCost;
            lad.Retry();
            easySave.SaveFile();
        }
    }

    public void Adfree_onretry (){
        lad.Retry();
        easySave.SaveFile();
    }


    public void StartGame () {
            lad.Retry();
    }

    public void SetToPlaymode(){
        isInPlayMode = true;
    }

}
