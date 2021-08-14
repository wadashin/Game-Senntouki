using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UAVCreate : MonoBehaviour
{
    [SerializeField] GameObject UAV;
    int t;
    int a;
    private void Start()
    {
        a = Random.Range(250,300);
    }

    void Update()
    {
        t++;
        if(t % a == 0)
        {
            Create();
        }
    }
    public void Create()
    {
    Vector3 player1 = this.gameObject.transform.position;
    Quaternion player2 = this.gameObject.transform.rotation;

        Debug.Log("play: " + player1);

    Instantiate(UAV, player1, player2);
    }
}
