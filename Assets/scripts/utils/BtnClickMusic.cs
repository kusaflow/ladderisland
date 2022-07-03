using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnClickMusic : MonoBehaviour
{
    public AudioSource S_audio;

    private void Update() {
        if (Input.GetMouseButtonDown(0)){
            playFX();
        }
    }

    public void playFX(){
        //Debug.Log(S_audio);
        S_audio.Play();
    }

}
