using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft1 : MonoBehaviour
{
    float y = 0;
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
            if (n > 300 || n == 0)
            {
                transform.Rotate(new Vector3(0, 0, z));
                z -= 0.2f;
                z = z - (z + 0.2f);
            } 
        }
        
    }
}
