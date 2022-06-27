using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_button_script_enable : MonoBehaviour
{

    public void whenButtonClickedPosition()
    {

        if ((GetComponent<CameraController>().enabled) == false)
        {
            GetComponent<CameraController>().enabled = true;
            GameObject.Find("MoveButton_main2").GetComponentInChildren<Text>().text = "Disable Movement";
        }


        else
        {
            GetComponent<CameraController>().enabled = false;
            GameObject.Find("MoveButton_main2").GetComponentInChildren<Text>().text = "Enable Movement";
        }
    }

    public void whenButtonClickedRotation()
    {

        if ((GetComponent<PointcloudController>().enabled) == false)
        {
            GetComponent<PointcloudController>().enabled = true;
            GameObject.Find("RotationButton_main2").GetComponentInChildren<Text>().text = "Disable Rotation";
        }


        else
        {
            GetComponent<PointcloudController>().enabled = false;
            GameObject.Find("RotationButton_main2").GetComponentInChildren<Text>().text = "Enable Rotation";
        }
    }

    public void whenButtonClickedCameraRotation()
    {

        if ((GetComponent<camera_rotation_controller>().enabled) == false)
        {
            GetComponent<camera_rotation_controller>().enabled = true;
            GameObject.Find("RotationButton_maincamera2").GetComponentInChildren<Text>().text = "Disable Camera Rotation";
        }


        else
        {
            GetComponent<camera_rotation_controller>().enabled = false;
            GameObject.Find("RotationButton_maincamera2").GetComponentInChildren<Text>().text = "Enable Camera Rotation";
        }
    }

}
