﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    float z = 0;
    bool a;

    // Start is called before the first frame update
    private void Update()
    {
        transform.position += new Vector3(0f, 0f, 0f);
        SousaRight();
    }

    public void SousaRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(new Vector3(0, z, 0));

            if (!a)
            {

                z += 0.5f;

                a = true;
            }

        }
        else
        {
            a = false;
            z = 0;
        }

    }

}