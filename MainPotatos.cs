using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using PolyLabs;
using PlayFab.ClientModels;

using PlayFab;
public class MainPotatos : MonoBehaviour
{
    public static double potatos_double;
    public static double coin_double;
    public static double rebirth;
    public  Text PotatoA;
    public static int rebcost;
    public int
        coins;

    public  Text coinDisplay;
    public static int multiplier = 1;
    public static int podevender = 1;
    public Text CoinDisplay2;




    void Start()
    {
        coins = (int)coin_double;
        potatos_double = PlayerPrefs.GetInt("potatos", 0);
        coin_double = PlayerPrefs.GetInt("coin", 0);
        multiplier = PlayerPrefs.GetInt("multi", 1);
        podevender = PlayerPrefs.GetInt("podevender", 1);
        Xp.level = PlayerPrefs.GetInt("level", 0);
        Xp.exp = PlayerPrefs.GetInt("xp", 0);
        Xp.tragetxp = PlayerPrefs.GetInt("txp", 1);
        rebirth = PlayerPrefs.GetInt("reb", 0);
        Shop.buymultiplier = PlayerPrefs.GetInt("buymult", 2);

    }

    // Update is called once per frame
    void Update()
    {

       // PlayFabManager.SendLeaderboard(coins);
       
        
        PotatoA.text = ShortScale.ParseDouble(potatos_double);
        coinDisplay.text = ShortScale.ParseDouble(coin_double);
        CoinDisplay2.text = ShortScale.ParseDouble(coin_double);





        //save


        PlayerPrefs.SetInt("potatos", (int)potatos_double);
        PlayerPrefs.SetInt("coin", (int)coin_double);
        PlayerPrefs.SetInt("multi", (int)multiplier);
        PlayerPrefs.SetInt("podevender", (int)podevender);
        PlayerPrefs.SetInt("xp", Xp.exp);
        PlayerPrefs.SetInt("level", Xp.level);
        PlayerPrefs.SetInt("txp", Xp.tragetxp);
        PlayerPrefs.SetInt("reb", (int)rebirth);
        PlayerPrefs.SetInt("buymult", Shop.buymultiplier);

    }



    public void secret()
    {

        potatos_double = 1;
        coin_double = 1;
        rebirth = 0;
        multiplier = 1;
        podevender = 1;
        Stats.rebcost = 1000000;
        Xp.level = 0;
        Xp.exp = 0;
        Xp.tragetxp = 1;
        Stats.playtime = 0;

    }
    
}
