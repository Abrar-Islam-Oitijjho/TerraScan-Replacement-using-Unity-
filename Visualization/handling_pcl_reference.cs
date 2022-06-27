using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handling_pcl_reference : MonoBehaviour
{

    public GameObject objectToFind;
    string objectName = "test4";

    public Vector2 panLimit;

    public float scrollspeed = 10f;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

   void Start()
    {
        objectToFind = GameObject.Find(objectName);
    }

    void Update()
    {
        

        Vector3 pos = objectToFind.transform.position;

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollspeed * 25f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
        pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        objectToFind.transform.position = pos;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        yaw = Mathf.Clamp(yaw, -360f, 360f);
        //the rotation range
        pitch = Mathf.Clamp(pitch, -360f, 360f);
        //the rotation range

        objectToFind.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}