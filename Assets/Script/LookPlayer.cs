using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject camera = GameObject.Find("MainCamera");
        this.transform.LookAt(camera.transform);
    }
}