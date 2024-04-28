using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource buttonAudioSource;
    public AudioClip buttonSound;
    public int sceneToLoad;

    private void Start()
    {
        buttonAudioSource = GameObject.Find("Menu BG").GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene(sceneToLoad); // Scene to load
        Debug.Log("New Scene Loded!");
        buttonAudioSource.PlayOneShot(buttonSound, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
     
}
