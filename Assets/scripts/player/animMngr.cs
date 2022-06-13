using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animMngr : MonoBehaviour
{

    public Animator anim;
    float animTimer = 0;
    float animLmt = 30;

    public int animIdxLimits;
    float CourantineDelayTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ladder.isFree){
            if (animTimer >= animLmt) {
                int choosen = (int)(Random.Range(2, animIdxLimits+1));
                anim.Play("idle"+choosen);
                animTimer = 0;
                animLmt = Random.Range(30, 60);
                CourantineDelayTime = CDT_ret(choosen);
                StartCoroutine(animState_reset());
                //anim.Play("idle");
            }else{
                animTimer += 10 * Time.deltaTime;
            }
        }
            
    }

    IEnumerator animState_reset(){
        yield return new WaitForSeconds(0.0166f * CourantineDelayTime);
        anim.Play("idle");
    }

    float CDT_ret(int choosen){
        if (choosen == 2){
            return 40;
        }else if (choosen == 3){
            return 40;
        }else if (choosen == 4){
            return 45;
        }else if (choosen == 5){
            return 50;
        }else if (choosen == 6){
            return 30;
        }


        return 0;
    }



}
