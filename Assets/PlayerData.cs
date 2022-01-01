using UnityEngine;


[CreateAssetMenu(fileName = "New Player Data", menuName = "Player Data", order = 54)]
public class PlayerData : ScriptableObject
{
    [SerializeField] private string playerName;
    [SerializeField] private KeyCode keyCode;
    [SerializeField] private string playerScore;

    public string PlayerName => playerName;
    public KeyCode KeyCode => keyCode;

    public string PlayerScore => playerScore;

}


