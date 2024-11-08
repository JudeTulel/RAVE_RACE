using UnityEngine;
using UnityEngine.UI;

public class LapManager : MonoBehaviour
{
    public static int MinutesTimer;
    public static int SecondsTimer;
    public static float MiliTimer;
    public static string MilliDisplay;

    public GameObject minutesBox;
    public GameObject secondsBox;
    public GameObject miliBox;

    void Update()
    {
        MiliTimer += Time.deltaTime * 10;
        MilliDisplay = MiliTimer.ToString("F0");
        miliBox.GetComponent<Text>().text = MilliDisplay;

        if (MiliTimer >= 10)
        {
            MiliTimer = 0;
            SecondsTimer += 1;
        }

        // Update secondsBox text with two-digit formatting
        secondsBox.GetComponent<Text>().text = SecondsTimer.ToString("00") + ".";

        if (SecondsTimer >= 60)
        {
            SecondsTimer = 0;
            MinutesTimer += 1;
        }

        // Update minutesBox text with two-digit formatting
        minutesBox.GetComponent<Text>().text = MinutesTimer.ToString("00") + ":";
    }
}
