using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ifstatementsscripts : MonoBehaviour
{
    float coffetemperature = 85.0f;
    float hotLimitemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TemperatureTest();

        coffetemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {

        // If the coffee's temperature is greater than hottest drinking temperature...
        if (coffetemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it  isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffetemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }


        //  If it is  neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }

    }

}


    

        
        

            
           

    








