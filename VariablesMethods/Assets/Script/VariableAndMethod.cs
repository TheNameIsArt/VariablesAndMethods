using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndMethod : MonoBehaviour
{
    public int currentAge = 23;
    private int yearlyIncrease = 1;
    public int ageIncrease;

    void Start()
    {
        Debug.Log("My current age is: " + currentAge);
        Debug.Log("My age in 1 year is: " + increaseAge(currentAge, yearlyIncrease));
        Debug.Log("My age in " + ageIncrease + " years: " + increaseAge(currentAge, ageIncrease));
    }

    private int increaseAge (int a, int b)
        {
            a += b;
            return (a);
        }
}
