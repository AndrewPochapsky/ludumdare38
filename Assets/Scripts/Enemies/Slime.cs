﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Enemy {

    private void Awake()
    {
        Health = 5;
        Speed = 2;
        JumpStrength = 2f;

        DG = transform.GetChild(0).GetComponent<DetectGround>();
        RB = GetComponent<Rigidbody2D>();

        planet = GameObject.FindObjectOfType<Planet>();
        player = GameObject.FindObjectOfType<Player>();

    }


    // Use this for initialization
    protected override void Start () {
        base.Start();
       
    }
	
	// Update is called once per frame
	void Update () {

        Move();
        //Jump();
	}

    private void FixedUpdate()
    {
        
        InduceGravity();
    }


     

}