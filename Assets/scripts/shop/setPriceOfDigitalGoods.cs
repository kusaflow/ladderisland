
using UnityEngine;

public class setPriceOfDigitalGoods : MonoBehaviour
{

    public TMPro.TextMeshProUGUI BBcoins;
    public TMPro.TextMeshProUGUI DollarCost;
    
    public int idx = 0;
    // Start is called before the first frame update
    void Start()
    {
        switch(idx){
            case 1 : BBcoins.text = globalV.Shop_P_1.x.ToString();
                    DollarCost.text = globalV.Shop_P_1.y.ToString();
                break;
            case 2 : BBcoins.text = globalV.Shop_P_2.x.ToString();
                    DollarCost.text = globalV.Shop_P_2.y.ToString();
                break;
            case 3 : BBcoins.text = globalV.Shop_P_3.x.ToString();
                    DollarCost.text = globalV.Shop_P_3.y.ToString();
                break;
            case 4 : BBcoins.text = globalV.Shop_P_4.x.ToString();
                    DollarCost.text = globalV.Shop_P_4.y.ToString();
                break;
            case 5 : BBcoins.text = globalV.Shop_P_5.x.ToString();
                    DollarCost.text = globalV.Shop_P_5.y.ToString();
                break;

        }
        
    }

}
