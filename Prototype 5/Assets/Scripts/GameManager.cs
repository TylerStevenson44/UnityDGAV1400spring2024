using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    // used list instead of array for this game.
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    private float spawnRate = 1.0f;
    private int score;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SpawnTarget()
    {
        //statement used for the inial spawn rate for objects
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd)
    {
        //add up our score while we play!
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

    }

    public void GameOver()
    {
        //game over method is refferenced for othe actions.
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //reset button reloads our scene from the beginning again.
    }

    public void StartGame(int difficulty)
    {
        //game starts on press of one of the difficulty buttons
        isGameActive = true;
        score = 0;
        //spawn rated devides by the int set in unity inspector for each button pressed.
        spawnRate /= difficulty;

        StartCoroutine(SpawnTarget());
        UpdateScore(0);
        //make sure the score starts at 0

        titleScreen.gameObject.SetActive(false);
        //hide all the title objects screen while the game is running.
    }
}
