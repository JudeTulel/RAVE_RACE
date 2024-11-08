using UnityEngine;
using UnityEngine.UI;

public class FinishLap : MonoBehaviour
{
    public GameObject halflaptrigg;
    public GameObject finishlaptrigg;

    public GameObject minutes;
    public GameObject seconds;
    public GameObject milliseconds;

    private void OnTriggerEnter(Collider other) // Corrected to OnTriggerEnter
    {
        if (other.CompareTag("Player")) // Use CompareTag for better performance
        {
            // Update seconds display with two-digit format
            seconds.GetComponent<Text>().text = LapManager.SecondsTimer.ToString("D2") + ".";

            // Update minutes display with two-digit format
            minutes.GetComponent<Text>().text = LapManager.MinutesTimer.ToString("D2") + ".";

            // Update milliseconds display with two-digit format
            milliseconds.GetComponent<Text>().text = LapManager.MiliTimer.ToString("D2");

            // Reset the lap timers
            LapManager.MinutesTimer = 0;
            LapManager.SecondsTimer = 0;
            LapManager.MiliTimer = 0;

            // Toggle the lap triggers
            halflaptrigg.SetActive(true);
            finishlaptrigg.SetActive(false);
        }
    }
}
