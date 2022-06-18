using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlSelMgr : MonoBehaviour
{

    public static int PlayerIdx = 0;
    public Image img;
     public List<Sprite> player = new List<Sprite>();

    public GameObject SelectBtn;
    public GameObject BuyBtn;
    
    private void Start() {
        PlayerIdx = 1;    
        //easySave.LoadFile();
    }


    // Update is called once per frame
    void Update()
    {
        // PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount+1);  
        //Debug.Log(player.Count); 
        if (player.Count != 0)
            img.sprite = player[PlayerIdx-1];

        
        //BtnMng
        if (globalV.Avatars[PlayerIdx-1]){
            SelectBtn.SetActive(true);
            BuyBtn.SetActive(false);
        }else{
            SelectBtn.SetActive(false);
            BuyBtn.SetActive(true);
        }
        
        
    }

   

    public void PrevChar(){
        PlayerIdx--;
        PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount);    
    }
    
    public void NextChar(){
        PlayerIdx++;
        PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount);
    }

    public void SelectAvatar(){
        globalV.CurrentAvatar = PlayerIdx;
    }
    
    public void BuyAvatar(){
        if (globalV.XP >= globalV.PerCharCost){
            globalV.XP-=globalV.PerCharCost;
            globalV.Avatars[PlayerIdx-1] = true;
            easySave.SaveFile();
        }
    }

}
