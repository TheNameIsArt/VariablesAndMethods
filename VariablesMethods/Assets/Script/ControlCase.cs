using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowControlAndCollectionTypes : MonoBehaviour
{
    public int day;
    public string activity;

    void Start()
    {      
        int dayNumber = day;  
        switch (dayNumber)
        {
            case 1: Debug.Log("Today is Monday and my most important activity today is: " + activity);
            break;
            case 2: Debug.Log("Today is Tuesday and my most important activity today is: " + activity);
            break;
            case 3: Debug.Log("Today is Wednesday and my most important activity today is: " + activity);
            break;
            case 4: Debug.Log("Today is Thursday and my most important activity today is: " + activity);
            break;
            case 5: Debug.Log("Today is Friday and my most important activity today is: " + activity);
            break;
            case 6: Debug.Log("Today is Saturday and my most important activity today is: " + activity);
            break;
            case 7: Debug.Log("Today is Sunday and my most important activity today is: " + activity);
            break;
            default: Debug.Log("Invalid day");
            break;
        }
    }
}
