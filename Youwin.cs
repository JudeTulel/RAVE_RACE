using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Youwin : MonoBehaviour
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
