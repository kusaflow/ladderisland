using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logoScreen : MonoBehaviour
{

    public string lvlID = "";
    public float WaitTime = 4;
    
    private void Start() {
        easySave.LoadFile();
        StartCoroutine(CR_reset());
    }

    IEnumerator CR_reset () {
        yield return new WaitForSeconds(WaitTime);
        deRirect();
    }
    

    public void deRirect(){
        SceneManager.LoadScene(lvlID, LoadSceneMode.Single);
    }


}
