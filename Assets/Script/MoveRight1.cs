using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight1 : MonoBehaviour
{
    float z = 0;

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
            var n = this.transform.localEulerAngles.z;
            if (n < 60 || n == 0 || n > 290 )
            {
                transform.Rotate(new Vector3(0, 0, z));
                z += 1f;
                z = z - (z - 1f);
            }
        }

    }
}

