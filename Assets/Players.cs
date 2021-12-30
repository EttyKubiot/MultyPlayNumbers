using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    private PlayerData player1 = new PlayerData();
    private PlayerData player2 = new PlayerData();

    private void Start()
    {
        player1.name = "esty";
        player1.keyCode = KeyCode.E;
        player2.name = "etty";
        player2.keyCode = KeyCode.T;
    }

}
