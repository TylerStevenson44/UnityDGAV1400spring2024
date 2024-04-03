using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//added UI so we can click the button

public class DifficultyButton : MonoBehaviour
{
    // our variables.
    private Button button;
    private GameManager gameManager;
    //public int for difficulty attached to each button so we can set it ourselves in the unity inspector.
    public int difficulty;


    // Start is called before the first frame update
    void Start()
    {
        //get our button object so we can click on it
        button = GetComponent<Button>();
        //find our game manager within unity
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //detect our click of one of the buttons
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked.");
        gameManager.StartGame(difficulty);
        //ref our game manager script so we can set the difficulty with each button

    }
}
