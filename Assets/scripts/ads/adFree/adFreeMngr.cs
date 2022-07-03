using UnityEngine;
using UnityEngine.Purchasing;

public class adFreeMngr : MonoBehaviour
{
    public GameObject adFreeBtn;

    // Update is called once per frame
    void Update()
    {
        adFreeBtn.SetActive(!globalV.isAdFree);
    }

    public void GoAdfree(Product product){
        globalV.isAdFree = true;
        easySave.SaveFile();
    }

}
