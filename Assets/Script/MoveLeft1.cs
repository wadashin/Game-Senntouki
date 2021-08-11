using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft1 : MonoBehaviour
{
    float z = 0;

    // Start is called before the first frame update
    private void Update()
    {
        transform.position += new Vector3(0f, 0f, 0f);
        SousaLeft();
        
     }

    public void SousaLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var n = this.transform.localEulerAngles.z;
            if (n > 300 || n == 0 || n < 0.9f)
            {
                transform.Rotate(new Vector3(0, 0, z));
                z -= 1f;
                z = z - (z + 1f);
            }
        }
        
    }
}
