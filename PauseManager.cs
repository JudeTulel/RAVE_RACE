using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel; // Assign your pause panel UI in the Inspector

    // This function pauses the game and displays the pause panel
    public void PauseGame()
    {
        Time.timeScale = 0f; // Stop time in the game
        pausePanel.SetActive(true); // Show the pause panel
    }

    // This function resumes the game and hides the pause panel
    public void ResumeGame()
    {
        Time.timeScale = 1f; // Resume time in the game
        pausePanel.SetActive(false); // Hide the pause panel
    }
}
