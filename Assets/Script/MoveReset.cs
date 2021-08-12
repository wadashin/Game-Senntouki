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
            
            z = 0;
            Debug.Log(z);
            myTransform.Rotate(new Vector3(0, 0, z));
        }
    }
}
