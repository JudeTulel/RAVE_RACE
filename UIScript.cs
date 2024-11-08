using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Text LapNumberText;
    public Text TotalLapsText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;
    public Text CheckPointTime;
    public Text WrongWayT;
    public GameObject CheckPointDisplay;
    public GameObject NewLapRecord;
    public GameObject WrongWayText;
    public int TotalLaps = 3;
    void Start()
    { 
       LapNumberText.text="0";
       TotalLapsText.text="/" + TotalLaps.ToString();
       CheckPointDisplay.SetActive(false);
       NewLapRecord.SetActive(false);
       WrongWayText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      //LapNumber
       LapNumberText.text= SaveScript.LapNumber.ToString(); 

       //LapTime
       if(SaveScript.LapTimeMinutes<=9)
       {
         LapTimeMinutesText.text="0"+(Mathf.Round(SaveScript.LapTimeMinutes).ToString())+" :";
       }
       else if(SaveScript.LapTimeMinutes>=10)
       {
         LapTimeMinutesText.text=(Mathf.Round(SaveScript.LapTimeMinutes).ToString())+" :";
       }
       if(SaveScript.LapTimeSeconds<=9)
       {
         LapTimeSecondsText.text="0"+(Mathf.Round(SaveScript.LapTimeSeconds).ToString());
       }
       else if (SaveScript.LapTimeSeconds>=10)
       {
         LapTimeSecondsText.text=(Mathf.Round(SaveScript.LapTimeSeconds).ToString());
       }

       //RaceTime
       if(SaveScript.RaceTimeMinutes<=9)
       {
         RaceTimeMinutesText.text="0"+(Mathf.Round(SaveScript.RaceTimeMinutes).ToString())+" :";
       }
       else if(SaveScript.RaceTimeMinutes>=10)
       {
         RaceTimeMinutesText.text=(Mathf.Round(SaveScript.RaceTimeMinutes).ToString())+" :";
       }
       if(SaveScript.RaceTimeSeconds<=9)
       {
         RaceTimeSecondsText.text="0"+(Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
       }
       else if (SaveScript.RaceTimeSeconds>=10)
       {
         RaceTimeSecondsText.text=(Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
       }

       //Best Laptime
       if(SaveScript.LastLapM== SaveScript.BestLapTimeM)
       {
         if(SaveScript.LastLapS<SaveScript.BestLapTimeS)
         {
            SaveScript.BestLapTimeS=SaveScript.LastLapS;
         }
       }
       if(SaveScript.LastLapM<SaveScript.BestLapTimeM)
       {
         SaveScript.BestLapTimeM=SaveScript.LastLapM;
         SaveScript.BestLapTimeS=SaveScript.LastLapS;
       }

       //BestLapTimeDisplay
       if(SaveScript.BestLapTimeM<=9)
       {
         BestLapTimeMinutes.text="0"+(Mathf.Round(SaveScript.BestLapTimeM).ToString())+" :";
       }
       else if(SaveScript.BestLapTimeM>=10)
       {
         BestLapTimeMinutes.text=(Mathf.Round(SaveScript.BestLapTimeM).ToString())+" :";
       }
       if(SaveScript.BestLapTimeS<=9)
       {
         BestLapTimeSeconds.text="0"+(Mathf.Round(SaveScript.BestLapTimeS).ToString());
       }
       else if (SaveScript.BestLapTimeS>=10)
       {
         BestLapTimeSeconds.text=(Mathf.Round(SaveScript.BestLapTimeS).ToString());
       }
       if (SaveScript.NewRecord==true)
       {
        NewLapRecord.SetActive(true);
        StartCoroutine(LapRecordOff());
       }

       //CheckPoint1
       if(SaveScript.CheckpointPass1==true)
       {
        SaveScript.CheckpointPass1=false;
        if(SaveScript.LapNumber>1)
        {
        CheckPointDisplay.SetActive(true);

        if (SaveScript.ThisCheckpoint1>SaveScript.LastCheckpoint1)
        {
          CheckPointTime.color= Color.red;
          CheckPointTime.text="-"+(SaveScript.ThisCheckpoint1 - SaveScript.LastCheckpoint1);
          StartCoroutine(CheckPointOff());
        }
        if(SaveScript.ThisCheckpoint1< SaveScript.LastCheckpoint1)
        {
          CheckPointTime.color = Color.green;
          CheckPointTime.text="+" + (SaveScript.LastCheckpoint1- SaveScript.ThisCheckpoint2);
          StartCoroutine(CheckPointOff());
        }
       }
       }


       //Checkpoint 2
       if(SaveScript.CheckpointPass2==true)
       {
        SaveScript.CheckpointPass2= false;
        if(SaveScript.LapNumber>1)
        {
        CheckPointDisplay.SetActive(true);

        if(SaveScript.ThisCheckpoint2>SaveScript.LastCheckpoint2)
        {
          CheckPointTime.color= Color.red;
          CheckPointTime.text= "-"+(SaveScript.ThisCheckpoint2- SaveScript.LastCheckpoint2);
          StartCoroutine(CheckPointOff());
        }
        if(SaveScript.ThisCheckpoint2< SaveScript.LastCheckpoint2)
        {
          CheckPointTime.color = Color.green;
          CheckPointTime.text="+" + (SaveScript.LastCheckpoint2- SaveScript.ThisCheckpoint2);
          StartCoroutine(CheckPointOff());
        }
        }
        }
        if(SaveScript.WrongWay==true)
        {
          WrongWayText.SetActive(true);
        }
        if(SaveScript.WrongWay==false)
        {
          WrongWayText.SetActive(false);
        }

      //Wrong way reset text
      if(SaveScript.WWTextReset==false)
      {
        WrongWayT.text="Wrong Way!";
      }
      if(SaveScript.WWTextReset==true)
      {
        WrongWayT.text="";
      }  
      

    }
    IEnumerator CheckPointOff()
    {
      yield return new WaitForSeconds(2);
      CheckPointDisplay.SetActive(false);
    }
    IEnumerator LapRecordOff()
    {
      yield return new WaitForSeconds(2);
      SaveScript.NewRecord=false;
      NewLapRecord.SetActive(false);
    }
}
