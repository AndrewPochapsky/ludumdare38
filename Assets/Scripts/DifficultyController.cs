﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour {

    private static int currentXP;
    private static int xpRate = 2;
	// Use this for initialization
	void Start () {
        InvokeRepeating("IncrementXP", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
        //IncrementXP();
	}

    public static int GetCurrentXP()
    {
        return currentXP;
    }

    public static int GetRate()
    {
        return xpRate;
    }

    public static void AddXP(int xp)
    {
        currentXP += xp;
    }

    protected void IncrementXP()
    {
        AddXP(xpRate);
    }


}
