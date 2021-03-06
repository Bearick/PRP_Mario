﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_zone : MonoBehaviour
{
    public float mouseScrollspeed = 1f;
    public float l;
    public float w;
    // Start is called before the first frame update
    void Start()
    {
        //get the length and width of the current object
        l = this.GetComponent<Collider>().bounds.size.x;
        w = this.GetComponent<Collider>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move the current object according to the mousescroll 
        if (Input.mouseScrollDelta.y < 0)
        {
            this.transform.position -= new Vector3(0, 0.5f, 0) * mouseScrollspeed;
        }
        if (Input.mouseScrollDelta.y > 0)
        {
            this.transform.position += new Vector3(0, 0.5f, 0) * mouseScrollspeed;
        }
    }
}
