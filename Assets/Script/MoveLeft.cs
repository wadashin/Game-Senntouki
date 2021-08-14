using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float z = 0;
    float x = 0;
    bool a;

    // Start is called before the first frame update
    private void Update()
    {
        //transform.position += new Vector3(0f, 0f, 0f);
        SousaLeft();
    }

    public void SousaLeft()
    {
        Transform myTransform = this.transform;
        Quaternion quaternion = this.transform.localRotation;
        //float z = quaternion.eulerAngles.z;

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            //transform.Rotate(new Vector3(0, z, 0));
            var n = this.transform.localEulerAngles.z;

            if (n <= 360 && n > 60)
            {
                Debug.Log(n);
                myTransform.Rotate(0f, z, 0f, Space.World);
                if (!a)
                {
                    z -= 0.5f;
                    a = true;
                }
            }

            
            if (n > 300 || n == 0 || n < 180)
            {
                myTransform.Rotate(0f, 0f, x);
                x -= 1f;
                x = x - (x + 1f);
            }
        }
        else
        {
            a = false;
            z = 0;
        }
    }

}
