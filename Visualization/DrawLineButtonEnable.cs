using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DrawLineButtonEnable : MonoBehaviour
{
    public void whenButtonClickedDrawLine()
    {
        if ((GetComponent<handle_lineRenderer_v2>().enabled) == false)
        {
            GetComponent<handle_lineRenderer_v2>().enabled = true;
            GameObject.Find("DrawLineButton").GetComponentInChildren<Text>().text = "Disable Draw Line";
            GetComponent<handle_lineRenderer_v2>().CameraToFind.GetComponent<Camera>().orthographic = true;
        }


        else
        {
            GetComponent<handle_lineRenderer_v2>().enabled = false;
            GameObject.Find("DrawLineButton").GetComponentInChildren<Text>().text = "Enable Draw Line";
            GetComponent<handle_lineRenderer_v2>().CameraToFind.GetComponent<Camera>().orthographic = false;
        }
    }
}
