using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] GameObject m_Cursor;
    [SerializeField] GameObject m_CursorRed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_Cursor.transform.position = transform.position;
        m_CursorRed.transform.position = transform.position;

        GameObject camera = GameObject.Find("MainCamera");

        var distance = Vector3.Distance(camera.transform.position, transform.position);
        m_Cursor.transform.localScale = new Vector3(distance * 0.0001f, distance * 0.0001f, 1);
        m_CursorRed.transform.localScale = new Vector3(distance * 0.0001f, distance * 0.0001f, 1);

        Vector3 posA = transform.position;
        Vector3 posB = camera.transform.position;
        float dis = Vector3.Distance(posA, posB);
        Debug.Log(dis);
        if (dis < 5000)
        {
            m_Cursor.gameObject.SetActive(false);
            m_CursorRed.gameObject.SetActive(true);
        }
        else
        {
            m_Cursor.gameObject.SetActive(true);
            m_CursorRed.gameObject.SetActive(false);
        }
    }
}

