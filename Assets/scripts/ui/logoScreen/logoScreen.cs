using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logoScreen : MonoBehaviour
{

    public string lvlID = "";

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deRirect(){
        SceneManager.LoadScene(lvlID, LoadSceneMode.Single);
    }


}
