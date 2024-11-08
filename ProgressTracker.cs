using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgressTracker : MonoBehaviour
{
    private AudioSource Player;
    private bool IsPlaying=false;
    public int CurrentWP=0;
    public int ThisWPNumber;
    public int LastWPNumber;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if(CurrentWP>LastWPNumber)
       {
        StartCoroutine(CheckDirection());
       }
       if(LastWPNumber>ThisWPNumber)
       {
        
        SaveScript.WrongWay=false;
       }
       if(LastWPNumber<ThisWPNumber)
       {
        
        SaveScript.WrongWay=true;
       }
    }
    IEnumerator CheckDirection()
    {
        yield return new WaitForSeconds(0.5f);
        ThisWPNumber=LastWPNumber;
    }
    
}
