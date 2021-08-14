using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UAVBase : MonoBehaviour
{
    [SerializeField] float m_Speed = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, m_Speed);
        gameObject.transform.position += velocity;

        UAV();
    }

    public abstract void UAV();
}

