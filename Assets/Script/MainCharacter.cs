using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] float m_Speed = 10f;
    public float n = 0;

    void Update()
    {
        Sousa();
        Tyokusinn();
    }

    void Tyokusinn()
    {
        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, -m_Speed);
        gameObject.transform.position += velocity;
    }

    void Sousa()
    {
        Transform myTransform = this.transform;
        Quaternion quaternion = this.transform.localRotation;
        float z = quaternion.eulerAngles.z;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
                

                //myTransform.Rotate(0f, n / 2, 0f, Space.World);

            if (z > -40)
            {
                n = n - 0.5f;
                myTransform.Rotate(0f, 0f, n / 2);
            }
            else
            {

            }

                n = n - (n + 1);
        }
    }
}
