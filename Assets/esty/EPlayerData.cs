using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EPlayerData
{
    public string name;
    public KeyCode keyCode;
    public int playerScore = 0;

    public EPlayerData(string newName, KeyCode newkeyCode)
    {
        name = newName;
        keyCode = newkeyCode;
    }

    //public void Clickkkk()
    //{
    //    if (Input.GetKeyDown(keyCode))
    //    {
    //        Debug.Log(keyCode);
    //    }
    //}
}
