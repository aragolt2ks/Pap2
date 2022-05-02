using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PolyLabs;

public class Stats : MonoBehaviour
{
    public Text pot, con, sell, gera, multi, ot, rebirth, nextlev, lvl, rebcostt;
    // Start is called before the first frame update
    public  static int playtime = 0;
    public int seconds = 0;
    public int minutes = 0;
    public int hours = 0;
    public int days = 0;
    public static double  rebcost;

    void Start()
    {
        StartCoroutine("playtimer");
        rebcost = PlayerPrefs.GetInt("rebc", 1000000);
        playtime = PlayerPrefs.GetInt("pt", 0);
    }

    // Update is called once per frame
    void Update()
    {

        pot.text = "Batatas:" + MainPotatos.potatos_double;
        con.text = "Coins:" + (int)MainPotatos.coin_double;
        sell.text = "Vende/s:" + MainPotatos.podevender;
        gera.text = "Gera/click:" + MainPotatos.multiplier;

        ot.text = "TempoJogado:" + days.ToString() + "D " + hours.ToString() + "H " + minutes.ToString() + "M " + seconds.ToString() + "S";
        rebirth.text = "Rebirths:" + MainPotatos.rebirth;
        nextlev.text = "ProximoNivel:" + Xp.exp + "/" + Xp.tragetxp;
        lvl.text = "Nivel:" + Xp.level;
        rebcostt.text = "Custo/Rebirth:" + ShortScale.ParseDouble(rebcost) + " coins";




        PlayerPrefs.SetInt("rebc",(int)rebcost);
        PlayerPrefs.SetInt("pt", playtime);
    }
    IEnumerator playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = (playtime % 60);
            minutes = (playtime / 60) % 60;
            hours = (playtime / 3600) % 24;
            days = (playtime / 85400) % 365;
           if (MainPotatos.potatos_double - MainPotatos.podevender >= 0) { 
                MainPotatos.potatos_double -= MainPotatos.podevender;
                MainPotatos.coin_double += MainPotatos.podevender;
            }
        }
    }


    public void rebirthmake()
    {
        if (MainPotatos.coin_double >= rebcost)
        {
            rebcost += 10000000;
            MainPotatos.potatos_double = 1;
            MainPotatos.coin_double = 0;
            MainPotatos.rebirth += 1 + Shop.mreb;
            Xp.level = 0;
            Xp.exp = 0;
            Xp.tragetxp = 1;
            MainPotatos.multiplier = 1;
            MainPotatos.podevender = 1;
        }
    }
}
