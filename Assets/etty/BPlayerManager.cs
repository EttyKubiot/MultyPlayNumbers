﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlayerManager : MonoBehaviour
{
    [SerializeField] private BGameManager bGameManager;

    public List<BPlayerData> players = new List<BPlayerData>();
    private List<KeyCode> myKeys = new List<KeyCode>();

    public bool Pressed = false;

    void Awake()
    {
        players.Add(new BPlayerData("Esty", KeyCode.Alpha0));
        players.Add(new BPlayerData("Etty", KeyCode.Alpha1));

        players[0].playerScore = 0;

        for (int i = 0; i < players.Count; i++)
        {
            myKeys.Add(players[i].keyCode);
        }
    }


    void Update()
    {
        for (int i = 0; i < myKeys.Count; i++)
        {
            if (Input.GetKeyDown(myKeys[i]))
            {
                Debug.Log(players[i].name);
                StartCoroutine(ClickOver());
                bGameManager.OnClick?.Invoke(i);
            }
        }
    }

    private IEnumerator ClickOver()
    {
        yield return new WaitForSeconds(0.2f);
        Pressed = false;
    }

}