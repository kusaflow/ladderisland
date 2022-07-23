using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalV : MonoBehaviour
{
    public static bool isDead =false;
    public static int PlayerCount = 7;


    public static int XP = 0;
    public static bool isAdFree = false;
    public static bool[] Avatars = new bool[20];
    public static int CurrentAvatar = 6;
    public static int ChickenPower = 0;
    public static int CheatPower = 0;
    public static int HighScore = 0;


    public static int retryCost = 250;
    public static int PerCharCost = 20000;
    public static int meat_PowerCost = 3000;
    public static int magnet_PowerCost = 4000;
    
    public static int PerIslandCrossReward = 50;
    


    //shops
    public static Vector2 Shop_P_1 = new Vector2(500, 0.99f);
    public static Vector2 Shop_P_2 = new Vector2(1000, 1.99f);
    public static Vector2 Shop_P_3 = new Vector2(5000, 9.99f);
    public static Vector2 Shop_P_4 = new Vector2(20000, 36.99f);
    public static Vector2 Shop_P_5 = new Vector2(50000, 69.99f);
    
    
    


}
