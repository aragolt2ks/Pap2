using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
   
{
    //test
    public Image b1,b2,b3,b4;
    public Sprite one,ten,onehundred;
    public static int buymultiplier=1;
    public int test;
    public static int mreb=0;
    public Text p1, p2, p3, p4;
    void Start()
    {
        b1.sprite = one;
        b2.sprite = one;
        b3.sprite = one;
        b4.sprite = one;
        buymultiplier = 1;
    }
    void Update()
    {
        test = buymultiplier;
        p1.text = "Pre�o: " + 100 * buymultiplier+" coins";
        p2.text = "Pre�o: " + 100 * buymultiplier+" coins";
        p3.text = "Pre�o: " + 1050 * buymultiplier+" coins";
        p4.text = "Pre�o: " + 15000 * buymultiplier+" coins";
    }
        public void change(int oi)
    {
       
        if (oi == 1)
        {
            b1.sprite = one;
            b2.sprite = one;
            b3.sprite = one;
            b4.sprite = one;
            
            buymultiplier = 1;

        }
        if (oi == 2)
        { 
            b1.sprite = ten;
            b2.sprite = ten;
            b3.sprite = ten;
            b4.sprite = ten;
           
            buymultiplier = 10;

        }
        if (oi == 3)
        {
            b3.sprite = onehundred;
            b4.sprite = onehundred;
            b1.sprite = onehundred;
            b2.sprite = onehundred;

            buymultiplier = 100;

        }
    }
    
    public void LALALA(int num)
    {
        if (num == 1 && MainPotatos.coin_double >= 100 * buymultiplier)
        {
            MainPotatos.podevender += buymultiplier;
            MainPotatos.coin_double -= 100*buymultiplier;


        }
        else
        {

        }
        if (num == 2 && MainPotatos.coin_double >= 100 * buymultiplier)
        {
            MainPotatos.multiplier +=  buymultiplier;
            MainPotatos.coin_double -= 100 * buymultiplier;

        }
        if (num == 3 && MainPotatos.coin_double >= 1050 * buymultiplier) 
        {
            MainPotatos.podevender += 5 * buymultiplier;
            MainPotatos.multiplier += 5 * buymultiplier;
            MainPotatos.coin_double -= 1000 * buymultiplier;
        }
        if(num==4 && MainPotatos.coin_double >= 15000 * buymultiplier)
        {
            MainPotatos.podevender += 90 * buymultiplier;
            MainPotatos.multiplier += 70 * buymultiplier;
            MainPotatos.coin_double -= 15000 * buymultiplier;
        }

    }
    public void rebshop(int nun)
    {
        if(nun==1&& MainPotatos.rebirth >= 1)
        {//aumenta a quantidade de upgrades que pode comprar por vez
            MainPotatos.rebirth -= 1 * buymultiplier;

           
        }
        if (nun == 2 && MainPotatos.rebirth >= 3)
        {//aumenta a quantidade de batatas por click
            MainPotatos.rebirth -= 3 * buymultiplier;
            MainPotatos.multiplier = MainPotatos.multiplier + 100;

        }
        if (nun == 3 && MainPotatos.rebirth >= 7)
        {//aumenta a quantidade de coins por venda 
            MainPotatos.rebirth -= 7 * buymultiplier;
            //MainPotatos.podevender+=

        }
        if (nun == 4 && MainPotatos.rebirth >= 10)
        {//aumenta a quantidad de rebirth que da por vez sem aumentar o pre�o
            MainPotatos.rebirth -= 10;
            mreb += 2;

        }
    }
 
}
