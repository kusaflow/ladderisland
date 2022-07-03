using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderSound : MonoBehaviour
{
    ladder lad;
    
    public AudioSource S_audio;
    public AudioSource s_splash;
    public AudioSource s_ground;

    // Start is called before the first frame update
    void Start()
    {
        lad = GetComponent<ladder>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lad.isTouchedDown){
           // Debug.Log("sss");
            if (!S_audio.loop)
                S_audio.Play();
            S_audio.loop = true;
            S_audio.pitch += 1 * Time.deltaTime;
        }else{
            S_audio.Stop();
            S_audio.loop = false;
            S_audio.pitch = 1;
        }
    }

    public void Play_onGround(){
        s_ground.Play();
    }
    
    public void Play_wALTERsPLASH(){
        s_splash.Play();
    }
    
    



}
