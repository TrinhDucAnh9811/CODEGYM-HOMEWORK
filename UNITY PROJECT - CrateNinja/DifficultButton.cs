using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }
    public void SetDifficulty()
    {
            Debug.Log(button.gameObject.name + " was clicked");
            gameManager.StartGame(difficulty);
    }
}
