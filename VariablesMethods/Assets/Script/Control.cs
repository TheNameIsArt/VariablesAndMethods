using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private int m = 1;
    private int tu = 2;
    private int w = 3;
    private int th = 4;
    private int f = 5;
    private int sa = 6;
    private int su = 7;

    public int day;
    public string activity;

    void Start()
    {
        if (day == m)
        {
            Debug.Log("Today is Monday and my most important activity today is: " + activity);
        }

        else if (day == tu)
        {
            Debug.Log("Today is Tuesday and my most important activity today is: " + activity);
        }

        else if (day == w)
        {
            Debug.Log("Today is Wednesday and my most important activity today is: " + activity);
        }

        else if (day == th)
        {
            Debug.Log("Today is Thursday and my most important activity today is: " + activity);
        }

        else if (day == f)
        {
            Debug.Log("Today is Friday and my most important activity today is: " + activity);
        }

        else if (day == sa)
        {
            Debug.Log("Today is Saturday and my most important activity today is: " + activity);
        }

        else if (day == su)
        {
            Debug.Log("Today is Sunday and my most important activity today is: " + activity);
        }

        else 
        {
            Debug.Log("Invalid day");
        }
        
    }
}
