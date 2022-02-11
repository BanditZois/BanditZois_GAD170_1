using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //variables up top
    /*
     multi line comment
    */
    public int fuel = 100;
    public int laps;
    public float lapProgress;
    public float reqLapProgress = 200f;


    //Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        //check how much fuel we have
        //if we still have more than 0 fuel we can keep going
        if (fuel > 0)
        {
            //we have fuel!
            //increase our progress and decrease our fuel
            lapProgress += 5; //increase by 5
            fuel--; //decrease by 1
        }
        else
        {
            //we don't have fuel
            Debug.Log("We've run out of fuel!");
        }


        //is our current progress equal to or higher than req progress
        if (lapProgress >= reqLapProgress)
        {
            //if it is, increase lap count and reset our current progress }
            laps++; //increase laps by 1
            lapProgress = 0; //reset out lap progress
        }
        Debug.Log("Current Fuel: " + fuel);
        Debug.Log("Completed Laps: " + laps);
    }
}