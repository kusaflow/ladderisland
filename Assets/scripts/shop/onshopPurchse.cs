using UnityEngine.Purchasing;
using UnityEngine;

public class onshopPurchse : MonoBehaviour
{
    public void purchasedDone(int coinsEarned){
        globalV.XP += coinsEarned;
        easySave.SaveFile();
    }
}
