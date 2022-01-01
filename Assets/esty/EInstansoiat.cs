using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EInstansoiat : MonoBehaviour
{

    [SerializeField] private Image[] numbersSprite;
    [SerializeField] private Image[] transparencySprite;
    [SerializeField] private Image transparency;
    [SerializeField] private int numbersPlace = 0;

    [SerializeField] private EPlayerManager playerManager;

    [SerializeField] private Text TextName;

    private string playerName;



    private void Update()
    {
        //foreach (KeyCode vKey in playerManager.myKeys)
        //{
        //    if (Input.GetKey(vKey))
        //    {
        //        //your code here

        //        Debug.Log(vKey);
        //    }
        //}


        if (Input.GetKey(playerManager.players[0].keyCode)&& Input.GetKeyDown(KeyCode.T)
           || Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.T))
        {
            for (int i = 0; i < transparencySprite.Length; i++)
            {
                transparencySprite[i].sprite = transparency.sprite;
                numbersPlace = 0;
                Debug.Log("Start Again");
            }

        }



        if (Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.T)
            || Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.T))
        {
             for (int i = 0; i < transparencySprite.Length; i++)
             {
                 transparencySprite[i].sprite = transparency.sprite;
                 numbersPlace = 0;
                 Debug.Log("Start Again");
             }

        }


         else if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.T))
         {
                    transparencySprite[numbersPlace].sprite = numbersSprite[numbersPlace].sprite;
                    numbersPlace++;


             if (Input.GetKey(KeyCode.E))
             {
                 playerName = playerManager.players[0].name;
                 playerManager.players[0].playerScore++;
             }

             else if (Input.GetKey(KeyCode.T))

             {
                playerName = playerManager.players[1].name;
                playerManager.players[1].playerScore++;

             }

             Change();
         }

    }
  

    private void Change()
    {
            TextName.text = playerName;
    }

 }

