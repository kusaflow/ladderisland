using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlSelMgr : MonoBehaviour
{

    public static int PlayerIdx = 0;
    public Image img;
     public List<Sprite> player = new List<Sprite>();
    
    private void Start() {
        PlayerIdx = 1;    
    }


    // Update is called once per frame
    void Update()
    {
        // PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount+1);  
        Debug.Log(player.Count); 
        if (player.Count != 0)
            img.sprite = player[PlayerIdx-1];
        
        
    }

   

    public void PrevChar(){
        PlayerIdx--;
        PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount);    
    }
    
    public void NextChar(){
        PlayerIdx++;
        PlayerIdx = Mathf.Clamp(PlayerIdx,1, globalV.PlayerCount);
    }


}
