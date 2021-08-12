using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Quaternion quaternion = this.transform.localRotation;

        var z = transform.localEulerAngles.z;
        if(Input.GetKey(KeyCode.LeftControl))
        {
            
            if (z > 181 && z < 360)
            {
                Debug.Log(z);
                //transform.Rotate
                myTransform.Rotate(0, 0, z);
                z += 1;
                z = z - (z - 1);
            }
        }
    }
}
