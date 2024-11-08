using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SaveScript : MonoBehaviour
{
    public static int LapNumber;
    public static bool LapChange = false;
    public static float LapTimeMinutes;
    public static float LapTimeSeconds;
    public static float RaceTimeMinutes;
    public static float RaceTimeSeconds;
    public static float BestLapTimeM;
    public static float BestLapTimeS;
    public static float LastLapM;
    public static float LastLapS;
    public static float GameTime;

    public static float LastCheckpoint1;
    public static float ThisCheckpoint1;
    public static float LastCheckpoint2;
    public static float ThisCheckpoint2;
    public static bool CheckpointPass1= false;
    public static bool CheckpointPass2= false;
    public static bool NewRecord= false;
    public static bool OnTheRoad= true;
    public static bool OnTheTerrain= false;
    public static bool WrongWay= false;
    public static bool HalfWayActivated= true;
    public static bool WWTextReset= false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(LapChange == true)
      {
        LapChange=false;
        LapTimeMinutes=0f;
        LapTimeSeconds=0f;
      }
      if(LapNumber>=1)
      {
        LapTimeSeconds=LapTimeSeconds+1*Time.deltaTime;
        RaceTimeSeconds= RaceTimeSeconds+1*Time.deltaTime;
        GameTime= GameTime+1*Time.deltaTime;
      }
      if(LapTimeSeconds>59)
      {
        LapTimeSeconds=0f;
        LapTimeMinutes++;
      }
      if(RaceTimeSeconds>59)
      {
        RaceTimeSeconds=0f;
        RaceTimeMinutes++;
      }
    }
}

