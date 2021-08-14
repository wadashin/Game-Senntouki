using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UAVCreate : MonoBehaviour
{
    [SerializeField] GameObject UAV;
    // Update is called once per frame
    private void Start()
    {
        Create();
    }

    void Update()
    {

        
    }
    public void Create()
    {
    Vector3 play1 = this.gameObject.transform.position;
    Quaternion play2 = this.gameObject.transform.rotation;

        Debug.Log("play: " + play1);

    Instantiate(UAV, play1, play2);
    }
}
