﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    Transform PlayerPos;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPos != null)
        {
            this.transform.position = PlayerPos.position;

        }
        this.transform.LookAt(Camera.main.transform);
    }
}