using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    float z = 0;
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
            myTransform.Rotate(0f, z, 0f, Space.World);
            if (!a)
            {
                z -= 0.5f;
                a = true;
            }

            var n = this.transform.localEulerAngles.z;
            if (n > 300 || n == 0 || n < 70)
            {
                myTransform.Rotate(0f, 0f, z);
                z -= 1f;
                z = z - (z + 1f);
            }
        }
        else
        {
            a = false;
            z = 0;
        }

    }

}
