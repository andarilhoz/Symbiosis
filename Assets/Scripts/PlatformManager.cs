﻿using UnityEngine;
using System.Collections;

public class PlatformManager : MonoBehaviour {

    public GameObject spawnMiddlePlat;

    public Transform generationPoint;
    private float platformWidth;
    // Use this for initialization
    void Start () {

	}
    
    // Update is called once per frame
    void Update(){
        platformWidth = spawnMiddlePlat.GetComponent<BoxCollider2D>().size.x - 0.05f;
        if (transform.position.x < generationPoint.position.x){
            transform.position = new Vector3(transform.position.x + platformWidth, transform.position.y -0.001f, transform.position.z);
            Instantiate(spawnMiddlePlat, transform.position, transform.rotation);
        }
    }
}
