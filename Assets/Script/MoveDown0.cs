using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown0 : MonoBehaviour
{
    [SerializeField] float m_Speed = 10;
    float x = 0;
    bool a;
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(x, 0, 0, Space.Self);
            if (!a)
            {
                x -= 1f;

                a = true;
            }
            else
            {
                a = false;
                x = 0;
            }
        }
    }
}
