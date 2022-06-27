using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cons_rot : MonoBehaviour
{

    public GameObject objectToFind;
    string objectName = "test4_main_window";
    public Transform objTarget;

    [SerializeField]
    float eulerAngX;
    [SerializeField]
    float eulerAngY;
    [SerializeField]
    float eulerAngZ;

    // Start is called before the first frame update
    void Start()
    {
        objectToFind = GameObject.Find(objectName);
    }

    // Update is called once per frame
    void Update()
    {
        eulerAngX = objectToFind.transform.localEulerAngles.x;
        eulerAngY = objectToFind.transform.localEulerAngles.y;
        eulerAngZ = objectToFind.transform.eulerAngles.z;

        Vector3 thePosition = transform.TransformDirection(eulerAngX, eulerAngY, eulerAngZ);

        //transform.LookAt(objTarget, Vector3.up);

        //transform.eulerAngles = new Vector3(-eulerAngX, -(eulerAngY-180.0f), 0.0f);

        //transform.eulerAngles = objectToFind.transform.eulerAngles;

        transform.eulerAngles = thePosition;
    }
}
