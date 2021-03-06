using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class top_button_script_enable : MonoBehaviour
{


    public void whenButtonClickedPosition_s1()
    {

        if ((GetComponent<CameraController>().enabled) == false)
        {
            GetComponent<CameraController>().enabled = true;
            GameObject.Find("MoveButton_top_s1").GetComponentInChildren<Text>().text = "Disable Movement";
        }


        else
        {
            GetComponent<CameraController>().enabled = false;
            GameObject.Find("MoveButton_top_s1").GetComponentInChildren<Text>().text = "Enable Movement";
        }
    }

    public void whenButtonClickedPosition_s2()
    {

        if ((GetComponent<CameraController>().enabled) == false)
        {
            GetComponent<CameraController>().enabled = true;
            GameObject.Find("MoveButton_top_s2").GetComponentInChildren<Text>().text = "Disable Movement";
        }


        else
        {
            GetComponent<CameraController>().enabled = false;
            GameObject.Find("MoveButton_top_s2").GetComponentInChildren<Text>().text = "Enable Movement";
        }
    }

    public void whenButtonClickedPosition_s3()
    {

        if ((GetComponent<CameraController>().enabled) == false)
        {
            GetComponent<CameraController>().enabled = true;
            GameObject.Find("MoveButton_top_s3").GetComponentInChildren<Text>().text = "Disable Movement";
        }


        else
        {
            GetComponent<CameraController>().enabled = false;
            GameObject.Find("MoveButton_top_s3").GetComponentInChildren<Text>().text = "Enable Movement";
        }
    }


    public void whenButtonClickedRotation_s1()
    {

        if ((GetComponent<top_PointcloudController>().enabled) == false)
        {
            GetComponent<top_PointcloudController>().enabled = true;
            GameObject.Find("RotationButton_top_s1").GetComponentInChildren<Text>().text = "Disable Rotation";
        }


        else
        {
            GetComponent<top_PointcloudController>().enabled = false;
            GameObject.Find("RotationButton_top_s1").GetComponentInChildren<Text>().text = "Enable Rotation";
        }
    }


    public void whenButtonClickedRotation_s2()
    {

        if ((GetComponent<top_PointcloudController>().enabled) == false)
        {
            GetComponent<top_PointcloudController>().enabled = true;
            GameObject.Find("RotationButton_top_s2").GetComponentInChildren<Text>().text = "Disable Rotation";
        }


        else
        {
            GetComponent<top_PointcloudController>().enabled = false;
            GameObject.Find("RotationButton_top_s2").GetComponentInChildren<Text>().text = "Enable Rotation";
        }
    }


    public void whenButtonClickedRotation_s3()
    {

        if ((GetComponent<top_PointcloudController>().enabled) == false)
        {
            GetComponent<top_PointcloudController>().enabled = true;
            GameObject.Find("RotationButton_top_s3").GetComponentInChildren<Text>().text = "Disable Rotation";
        }


        else
        {
            GetComponent<top_PointcloudController>().enabled = false;
            GameObject.Find("RotationButton_top_s3").GetComponentInChildren<Text>().text = "Enable Rotation";
        }
    }

}
