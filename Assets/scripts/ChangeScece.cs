using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScece : MonoBehaviour
{
    public string lvlID = "";

    public void deRirect(){
        SceneManager.LoadScene(lvlID, LoadSceneMode.Single);
    }
}
