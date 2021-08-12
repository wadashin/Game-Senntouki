using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    [SerializeField] GameObject m_Audio; 
    void Start()
    {
        m_Audio.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teki")
        {
            m_Audio.gameObject.SetActive(true);
        }
        else
        {
            m_Audio.gameObject.SetActive(false);
        }
    }
}
