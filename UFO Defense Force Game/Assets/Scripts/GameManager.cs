using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public GameObject gameOverText;
    void Awake()
    {
        Time.timeScale = 1; // set our time to normal on awake
        isGameOver = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame(); // start the EndGame method
        }
        else
        {
            gameOverText.gameObject.SetActive(false); // hides Game over UI text
        }
    }
    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); // reveals the Game over  text 
        Time.timeScale = 0; // set time to 0 to freeze the game
    }
}