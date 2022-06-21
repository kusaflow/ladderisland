using UnityEngine;
using TigerForge;

public class easySave : MonoBehaviour
{

    
    public static void SaveFile()
    {

        EasyFileSave myF = new EasyFileSave("saveData");
        myF.Add("xp", globalV.XP);
        myF.Add("AdFree", globalV.isAdFree);

        myF.Add("chickenPower", globalV.ChickenPower);
        myF.Add("CheatPower", globalV.CheatPower);

        //Avatars
        for (int i =0; i<globalV.Avatars.Length; i++){    
            myF.Add("A_"+ i, globalV.Avatars[i]);
        }
        
        myF.Add("CurrAvatar", globalV.CurrentAvatar);
        
        myF.Save();
        Debug.Log("Saved");
        Debug.Log(Application.persistentDataPath);
        
    }



    public static void LoadFile()
    {
        Debug.Log(Application.persistentDataPath);
        EasyFileSave myF = new EasyFileSave("saveData");
        if (myF.Load())
        {
            globalV.XP = myF.GetInt("xp");
            globalV.isAdFree = myF.GetBool("AdFree");
            
            globalV.ChickenPower = myF.GetInt("chickenPower");
            globalV.CheatPower = myF.GetInt("CheatPower");

            //Avatar 
            for (int i =0; i<globalV.Avatars.Length; i++){    
                globalV.Avatars[i] = myF.GetBool("A_"+i);
            }

            globalV.CurrentAvatar = myF.GetInt("CurrAvatar");

            myF.Dispose();
            Debug.Log("loaded");

        }else{
            //rockets 
            globalV.Avatars[0] = true;
            for (int i =1; i<globalV.Avatars.Length; i++){    
                globalV.Avatars[i] = false;
            }

            globalV.CurrentAvatar = 1;
            globalV.XP = 10000;
            globalV.ChickenPower = 0;
            globalV.CheatPower = 0;
            globalV.isAdFree = false;

        }

    }
}
