using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float sensity = 100f;

    public Transform player;

    float xRotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
