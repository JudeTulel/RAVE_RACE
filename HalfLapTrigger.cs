using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HalfLapTrigger : MonoBehaviour
{
  public  GameObject halflapTrigger;
  public GameObject finishlapTrigger;

  private void OnTriggerEnter(Collider other)
  {
    if (other.tag=="Player")
    {
        finishlapTrigger.SetActive(true);
        halflapTrigger.SetActive(false);
    }
  }
}
