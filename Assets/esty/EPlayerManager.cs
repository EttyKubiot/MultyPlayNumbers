using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPlayerManager : MonoBehaviour
{
    //public EPlayerData player1 = new EPlayerData();
    //public EPlayerData player2 = new EPlayerData();
    public List<EPlayerData> players = new List<EPlayerData>();

    List<KeyCode> myKeys = new List<KeyCode>();

    void Awake()
    {
        players.Add(new EPlayerData("0", KeyCode.Alpha0));
        players.Add(new EPlayerData("1", KeyCode.Alpha1));

        players[0].playerScore = 0;

        for (int i = 0; i < players.Count; i++)
        {
            myKeys.Add(players[i].keyCode);
        }
    }



    //void Update()
    //{
    //    foreach (KeyCode vKey in myKeys)
    //    {

    //        if (Input.GetKey(vKey))
    //        {
    //            //your code here

    //            Debug.Log(vKey);
    //        }
    //    }
    //}



}

