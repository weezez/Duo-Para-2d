﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMain : MonoBehaviour {

    public GameObject Main;

    public GameObject Follower;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
    Vector3 newPos = Main.transform.position;
        newPos.y = Follower.transform.position.y;
        Follower.transform.position = newPos;
    }
}
