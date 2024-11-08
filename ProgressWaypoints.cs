using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking=0;
    //public bool PenaltyOption=false;
    //public int PenaltyWaypoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Progress"))
        {
            CarTracking=other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking<WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                Debug.Log("CurrentWP" + other.GetComponent<ProgressTracker>().CurrentWP);
            }
            if(CarTracking > WPNumber)
            {
                SaveScript.WrongWay=true;
                
            }
            /*if(PenaltyOption==true)
            {
                if(CarTracking<PenaltyWaypoint)
                {
                    Debug.Log("Penalty")
                }
            }*/
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
