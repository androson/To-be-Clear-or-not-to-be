using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ScreenPause();
    }
    public void LoadLevel()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Mohit");

    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
    #region Pause
    public void ScreenPause()
    {
        // if bool true then allow pause functionality 

        // when esc pressed it pauses the game, stops time and pops up the pause screen
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0;
            pauseScreen.SetActive(true);
            isPaused = true;
            
        }
        // if already paused then does the opposite
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {

            Time.timeScale = 1;
            pauseScreen.SetActive(false);
            isPaused = false;
        }

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    #endregion
}
