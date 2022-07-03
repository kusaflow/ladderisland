using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyPOwerMngr : MonoBehaviour
{
    public void BuyChicken(){
        if (globalV.XP >= globalV.meat_PowerCost){
            globalV.XP -= globalV.meat_PowerCost;
            globalV.ChickenPower+=5;
            easySave.SaveFile();
        }
    }
    
    public void BuyCheat(){
        if (globalV.XP >= globalV.magnet_PowerCost){
            globalV.XP -= globalV.magnet_PowerCost;
            globalV.CheatPower+=5;
            easySave.SaveFile();
        }
    }


}
