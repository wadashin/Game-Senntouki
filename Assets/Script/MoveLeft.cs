using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //float y = 0;
    float z = 0;
    bool a;

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

            transform.Rotate(new Vector3(0, z, 0));

            if (!a)
            {
                //y -= 1;
                z -= 0.5f;

                a = true;
            }
            //y = y - (y + 1);
        }
        else
        {
            a = false;
            z = 0;
        }

    }

}
