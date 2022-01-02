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
    [SerializeField] private EGameManager eGameManager;

    [SerializeField] private Text TextName;

    private string playerName;

    private void Start()
    {
        eGameManager.OnClick += ClickResults;
    }

    private void ClickResults(int PlayerIndex)
    {
        
        if (playerManager.Pressed == true)
        {
            playerManager.Pressed = false;

            for (int i = 0; i < transparencySprite.Length; i++)
            {
                transparencySprite[i].sprite = transparency.sprite;
                numbersPlace = 0;
                Debug.Log("Start Again");
            }

        }

        else
        {
            playerManager.Pressed = true;

            transparencySprite[numbersPlace].sprite = numbersSprite[numbersPlace].sprite;

            numbersPlace = (numbersPlace + 1) % numbersSprite.Length;

            playerManager.players[PlayerIndex].playerScore++;
            Debug.Log($"score{playerManager.players[PlayerIndex].name}: " +
               $"{playerManager.players[PlayerIndex].playerScore}");

            TextName.text = playerManager.players[PlayerIndex].name;
            TextName.text = $"Well done: {playerManager.players[PlayerIndex].name}";

        }

    }

 }

