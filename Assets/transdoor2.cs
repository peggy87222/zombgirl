﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transdoor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
        Application.LoadLevel("TestMap");
    }
}
