using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpMngr : MonoBehaviour
{
    public GameObject powerList;
    public GameObject progress;
    public Scrollbar progressBar;

    public float powerTime = 1;

    float V_progress = 1;
    
    public bool isPowerConsumed = false;
    public bool isChicken = false;

    // Update is called once per frame
    void Update()
    {
        progressBar.size = V_progress;
        if (V_progress >= 1)
            isPowerConsumed = false;
        else
            isPowerConsumed = true;

        if (isPowerConsumed){
            progress.SetActive(true);
            powerList.SetActive(false);
            V_progress += (1/powerTime) * Time.deltaTime;

        }else{
            progress.SetActive(false);
            powerList.SetActive(true);
        }
    }

    public void OnPowerPressed(bool b_isChicken){
        if (globalV.isDead)
            return;
        if (b_isChicken){
            if (globalV.ChickenPower > 0)
                globalV.ChickenPower--;
            else
                return;
        }else{
            if (globalV.CheatPower > 0)
                globalV.CheatPower--;
            else
                return;    
        }
        isChicken = b_isChicken;
        V_progress = 0;
    }

}
