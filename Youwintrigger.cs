using UnityEngine;

public class Youwintrigger : MonoBehaviour
{
    public GameObject YouwinPanel;
   public AudioSource winAudio;

   private void OnTriggerEnter(Collider other)
   {
    if (other.tag =="Player" )
    {
        YouwinPanel.SetActive(true);
        winAudio.Play();
        Time.timeScale = 0;
    }
   }
}
