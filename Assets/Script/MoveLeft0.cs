using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft0 : MonoBehaviour
{
    float z = 0;
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, z);
            
            z -= 1;
            z = z - (z + 1);
        }
    }
}
