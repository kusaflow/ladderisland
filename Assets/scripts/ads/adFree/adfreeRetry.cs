using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adfreeRetry : MonoBehaviour
{
    public GameObject WithAd;
    public GameObject WithOutAd;
    public GameMenuMngr menu;
    
    int retryCount = 0;

    private void Start() {
        retryCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        WithAd.SetActive(!globalV.isAdFree);
        WithOutAd.SetActive(globalV.isAdFree);
        if (globalV.isAdFree)
            WithOutAd.SetActive(retryCount < 5 ? true : false);
    }
    
    public void f_retryCount() {
        if (retryCount < 5){
            //Debug.Log("Ss");
            menu.Adfree_onretry();
        }
        
        retryCount++;
    }
}
