using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPlayerData : MonoBehaviour
{
    public string name;
    public KeyCode keyCode;
    public int playerScore = 0;

    public BPlayerData(string newName, KeyCode newkeyCode)
    {
        name = newName;
        keyCode = newkeyCode;
    }
}
