using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Timelimit : MonoBehaviour
{
    // Public variables for setting in the Inspector
    public float startingTime = 20f;
    public Text countDownText;
    public GameObject gameOverPanel;
    public AudioSource timeAudio;

    // Private variable to track the current time
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Set the current time to the starting time
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Decrement the timer by the time passed since the last frame
        currentTime -= Time.deltaTime;
        
        // Update the text element with the remaining time
        countDownText.text = "Remaining Time: " + currentTime.ToString("0");

        // Check if the timer has reached zero
        if (currentTime <= 0)
        {
            // Stop the timer from going into negative values
            currentTime = 0;

            // Play the audio if assigned
            if (timeAudio != null)
            {
                timeAudio.Play();
            }

            // Display the game over panel if assigned
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }

            // Stop the game time
            Time.timeScale = 0f;
        }
    }
}
