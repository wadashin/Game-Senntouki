using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] GameObject m_Player;
    private Vector3 offset;

    

    void Start()
    {
        offset = transform.position - m_Player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion quaternion = m_Player.transform.rotation;
        float y = quaternion.eulerAngles.y;

        transform.position = m_Player.transform.position + offset;
        transform.Rotate(new Vector3(0, y, 0));
    }
}
