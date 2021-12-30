using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNum : MonoBehaviour
{
    [SerializeField] private GameEvent onPlay;
    [SerializeField] private Text scoreText;
    [SerializeField] private PlayerData playerData;

    public void playerName()
    {
        onPlay.Raise();
        scorePlayer();


    }

    public void scorePlayer()
    {
        scoreText.text = playerData.PlayerScore;

    }
}
