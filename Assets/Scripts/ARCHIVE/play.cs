﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void OnMouseDown(){

		//close video
		GameObject vid = GameObject.FindGameObjectWithTag("video");
		vid.GetComponent<VideoPlayer>().Play();
		
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
