using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public float n = 0;

    void Update()
    {
        Sousa();
    }

    void Sousa()
    {
        Transform myTransform = this.transform;
        Quaternion quaternion = this.transform.localRotation;
        float z = quaternion.eulerAngles.z;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
                myTransform.Rotate(0f, n / 2, 0f, Space.World);

            if (z > -40)
            {
                n = n - 0.5f;
                myTransform.Rotate(0f, 0f, n / 2);
            }
            else
            {

            }
                n = n - (n + 1);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            myTransform.Rotate(-n / 2, 0, 0f);
        }
    }
}
