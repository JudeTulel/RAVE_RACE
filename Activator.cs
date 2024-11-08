using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Activator : MonoBehaviour
{
    
   private void OnTriggerEnter(Collider other)
   {
    if(other.gameObject.CompareTag("Progress"))
    {
        SaveScript.HalfWayActivated=true;
    }
   }
}
