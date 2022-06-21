using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCardMngr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        globalV.XP += ladder.score * globalV.PerIslandCrossReward;
        easySave.SaveFile();
    }

    
}
