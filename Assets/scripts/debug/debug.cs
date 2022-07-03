using UnityEngine;
using UnityEngine.Purchasing;

public class debug : MonoBehaviour
{
    public string str;
    public TMPro.TextMeshProUGUI text;

    public void k_SetText(string s){
        str = s;
    }

    void Update()
    {
        text.text = str;
    }

    public void PurchaseFailed(Product product, PurchaseFailureReason fail){
        str = fail.ToString();
    }
}
