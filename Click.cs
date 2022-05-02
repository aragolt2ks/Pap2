using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Click : MonoBehaviour
{
    public GameObject plusObject;
    public Text plustext;
    public int potatoincrease;
    public static bool clicking;
    public Button b1;



    void start()
    {

        Button btn = b1.GetComponent<Button>();
        btn.onClick.AddListener(clickbol);
    }
    void Update()
    {
        potatoincrease = MainPotatos.multiplier;
        plustext.text = "+" + MainPotatos.multiplier;


    }
    public void click()
    {
        MainPotatos.potatos_double += MainPotatos.multiplier;


        plusObject.SetActive(false);
        plusObject.transform.position = new Vector3(Random.Range(400, 600 + 1), Random.Range(800, 900 + 1), 0);
        plusObject.SetActive(true);


    
        StartCoroutine(fly());

        Xp.exp += 1 + Xp.level;


    }

    IEnumerator fly()
    {
        for (int i = 0; i <= 19; i++)
        {
            yield return new WaitForSeconds(0.01f);
            plusObject.transform.position = new Vector3(plusObject.transform.position.x, plusObject.transform.position.y + 2, 0);

        }
        plusObject.SetActive(false);

    }
    public void clickbol()
    {
        clicking = true;
    }

}

