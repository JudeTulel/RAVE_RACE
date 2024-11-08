using UnityEngine;

public class GameOverscript : MonoBehaviour
{
   public GameObject gameoverPanel;
   public AudioSource gameOverAudio;

   private void OnTriggerEnter(Collider other)

    {
        gameoverPanel.SetActive(true);
        gameOverAudio.Play();
        Time.timeScale = 0;
    }
   
}
