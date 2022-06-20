using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyPOwerMngr : MonoBehaviour
{
    public void BuyChicken(){
        if (globalV.XP >= globalV.PowerCost){
            globalV.XP -= globalV.PowerCost;
            globalV.ChickenPower+=5;
            easySave.SaveFile();
        }
    }
    
    public void BuyCheat(){
        if (globalV.XP >= globalV.PowerCost){
            globalV.XP -= globalV.PowerCost;
            globalV.CheatPower+=5;
            easySave.SaveFile();
        }
    }


}
