using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
        SaveScript.WWTextReset=true;
        StartCoroutine(WrongWayReset());
        if(SaveScript.HalfWayActivated==true)
      {
        SaveScript.HalfWayActivated=false;
        SaveScript.LastLapM = SaveScript.LapTimeMinutes;
        SaveScript.LastLapS = SaveScript.LapTimeSeconds;
        SaveScript.LapNumber++;
        SaveScript.LapChange=true;

        if(SaveScript.LapNumber==2)
        {
            SaveScript.BestLapTimeM=SaveScript.LastLapM;
            SaveScript.BestLapTimeS=SaveScript.LastLapS;
            SaveScript.NewRecord=true;
        }
        SaveScript.CheckpointPass1= false;
        SaveScript.CheckpointPass2= false;
        SaveScript.LastCheckpoint1= SaveScript.ThisCheckpoint1;
        SaveScript.LastCheckpoint2= SaveScript.ThisCheckpoint2;
       }
    }

}
 IEnumerator WrongWayReset()
{
    yield return new WaitForSeconds(1.5f);
    SaveScript.WWTextReset=false;
}
}
