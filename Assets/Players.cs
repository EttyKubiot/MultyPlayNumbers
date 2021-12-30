using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    [SerializeField] private Text nameText;
   

    public void UpdateDisplayUI(PlayerData playerData)
    {
        nameText.text = playerData.PlayerName;
       
    }

}
