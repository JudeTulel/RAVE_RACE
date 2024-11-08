using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckPoint : MonoBehaviour
{
    public bool CheckPoint1=true;
    public bool CheckPoint2=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (CheckPoint1==true)
            {
                SaveScript.ThisCheckpoint1= SaveScript.GameTime;
                SaveScript.CheckpointPass1=true;
            }
            if(CheckPoint2==true)
            {
              SaveScript.ThisCheckpoint2= SaveScript.GameTime;
                SaveScript.CheckpointPass2=true;  
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
