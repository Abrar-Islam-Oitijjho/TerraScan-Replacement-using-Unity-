using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerUpdated : MonoBehaviour
{
    public float panSpeed = 4f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit;

    public float scrollspeed = 10f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollspeed * 50f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        yaw = Mathf.Clamp(yaw, -360f, 360f);
        //the rotation range
        pitch = Mathf.Clamp(pitch, -360f, 360f);
        //the rotation range

        transform.eulerAngles = new Vector3(pitch+270.0f, yaw, 0.0f);
    }
}
