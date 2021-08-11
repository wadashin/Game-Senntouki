﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float m_Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, -m_Speed);
        gameObject.transform.position += velocity;// * Time.deltaTime;
    }
}
