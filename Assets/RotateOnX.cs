﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Time.deltaTime * 5, 0, 0));
    }
}
