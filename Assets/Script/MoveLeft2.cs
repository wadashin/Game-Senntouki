using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft2 : MonoBehaviour
{
    float z = 0;
    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftArrow))
        {
            var n = this.transform.localEulerAngles.z;
            if (n > 250 && n < 360 && n != 0 )
            {
                transform.Rotate(new Vector3(0, 0, z));
                z += 1f;
                z = z - (z - 1f);
            }
            else
            {
                z = 0;
            }

        }
    }
}
