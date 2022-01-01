using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstatiateNumbers : MonoBehaviour
{
    [SerializeField] private Image[] numbersSprite;
    [SerializeField] private Image[] transparencySprite;
    [SerializeField] private Image transparency;
    [SerializeField] private int numbersPlace = 0;
    [SerializeField] private PlayerNum[] playerNum;

    private string myname;
   
    private void Start()
    {
       
    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.D) 
            || Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            for (int i = 0; i < transparencySprite.Length; i++)
            {
                transparencySprite[i].sprite = transparency.sprite;
                numbersPlace = 0;
                Debug.Log("Start Again");
            }

        }
       

        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            transparencySprite[numbersPlace].sprite = numbersSprite[numbersPlace].sprite;
            numbersPlace++;
            if (Input.GetKey(KeyCode.A))
            {
                playerNum[0].playerName();
            }

            if (Input.GetKey(KeyCode.D))
            {
                playerNum[1].playerName();
            }
        }

    }

}
