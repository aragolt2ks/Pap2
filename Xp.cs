using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Xp : MonoBehaviour
{
    public static int exp,level;
    public static int tragetxp=1;
    public Slider xp;
    public Text leveltext;
    
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
        leveltext.text = "" + level;
        if (exp >= tragetxp)
        {
            level += 1;
            exp -=tragetxp;
            tragetxp += 100;
        
        }
    }
  

}
