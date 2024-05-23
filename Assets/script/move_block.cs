using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_block : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;
    public float speed_block;
    public float progres;

    public GameObject player;

    private void Start()
    {
        transform.position = start;
    }
    private void FixedUpdate()
    {
        if (progres < 1)
        {
            transform.position = Vector3.Lerp(start, end, progres);
            progres += speed_block;
        }
        else
        {
            progres = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.parent = transform;
    }
    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}