﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopaeController : MonoBehaviour {

    private CircleCollider2D hopCol;
	// Use this for initialization
	void Start () {
        hopCol = gameObject.GetComponent<CircleCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("map"))
        {
            StartCoroutine(delayCoroutine());
        }
    }

    IEnumerator delayCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        hopCol.isTrigger = false;
    }
}