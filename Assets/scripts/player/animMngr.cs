using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animMngr : MonoBehaviour
{

    public Animator anim;
    float animTimer = 0;
    float animLmt = 30;

    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play(globalV.PlayerIDX+ "_0");
    }

    // Update is called once per frame
    void Update()
    {
        if (ladder.isFree){
            if (animTimer >= animLmt) {
                int choosen = (int)(Random.Range(1, 6));
                anim.Play(globalV.PlayerIDX+ "_"+choosen);
                animTimer = 0;
                animLmt = Random.Range(30, 60);
                //CourantineDelayTime = CDT_ret(choosen);
                StartCoroutine(animState_reset());
                //anim.Play("idle");
            }else{
                animTimer += 10 * Time.deltaTime;
            }
        }
            
    }

    IEnumerator animState_reset(){
        yield return new WaitForSeconds(1);
        anim.Play(globalV.PlayerIDX+ "_0");
    }


}
