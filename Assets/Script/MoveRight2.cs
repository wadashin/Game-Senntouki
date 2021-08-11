using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight2 : MonoBehaviour
{
    float z = 0;
    void Update()
    {
        if (!Input.GetKey(KeyCode.RightArrow))
        {
            var n = this.transform.localEulerAngles.z;
            if (n < 110 && n > 0)
            {
                transform.Rotate(new Vector3(0, 0, z));
                z -= 1f;
                z = z - (z + 1f);
            }
            else
            {
                z = 0;
            }

            if (n < 0.5f)
            {
                z = 0;
            }
        }


    }
}
