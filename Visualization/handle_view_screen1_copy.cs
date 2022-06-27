using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handle_view_screen1_copy : MonoBehaviour
{
    public GameObject CameraToFind;
    
    public GameObject objectToFind1;
    public GameObject objectToFind2;
    public GameObject objectToFind3;

    public Dropdown dropdownToFind1;
    public Dropdown dropdownToFind2;
    public Dropdown dropdownToFind3;

    public Button buttonToFind1;
    public Button buttonToFind2;
    public Button buttonToFind3;
    public Button buttonToFind4;
    public Button buttonToFind5;
    public Button buttonToFind6;


    public void handle_screen_view()
    {

        CameraToFind.GetComponent<Camera>().rect = new Rect(0.0f, 0.0f, 0.65f, 1.0f);

        //for one screen------------------------------------------------------------------------------------------------------------

        if ((dropdownToFind2.value == 0) & (dropdownToFind3.value == 0))
        {
            if (dropdownToFind1.value == 1)
            {
                objectToFind1.GetComponent<Camera>().enabled = true;
                objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.0f, 0.35f, 1.0f);
                objectToFind2.GetComponent<Camera>().enabled = false;
                objectToFind3.GetComponent<Camera>().enabled = false;

                buttonToFind1.gameObject.SetActive(true);
                buttonToFind1.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind2.gameObject.SetActive(false);
                buttonToFind3.gameObject.SetActive(false);

                buttonToFind4.gameObject.SetActive(true);
                buttonToFind4.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind5.gameObject.SetActive(false);
                buttonToFind6.gameObject.SetActive(false);

            }

            if (dropdownToFind1.value == 2)
            {
                objectToFind2.GetComponent<Camera>().enabled = true;
                objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.0f, 0.35f, 1.0f);
                objectToFind1.GetComponent<Camera>().enabled = false;
                objectToFind3.GetComponent<Camera>().enabled = false;

                buttonToFind2.gameObject.SetActive(true);
                buttonToFind2.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind1.gameObject.SetActive(false);
                buttonToFind3.gameObject.SetActive(false);

                buttonToFind5.gameObject.SetActive(true);
                buttonToFind5.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind4.gameObject.SetActive(false);
                buttonToFind6.gameObject.SetActive(false);

            }

            if (dropdownToFind1.value == 3)
            {
                objectToFind3.GetComponent<Camera>().enabled = true;
                objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.0f, 0.35f, 1.0f);
                objectToFind2.GetComponent<Camera>().enabled = false;
                objectToFind1.GetComponent<Camera>().enabled = false;

                buttonToFind3.gameObject.SetActive(true);
                buttonToFind3.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind2.gameObject.SetActive(false);
                buttonToFind1.gameObject.SetActive(false);

                buttonToFind6.gameObject.SetActive(true);
                buttonToFind6.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind5.gameObject.SetActive(false);
                buttonToFind4.gameObject.SetActive(false);
            }

            
        }


        //for two screen------------------------------------------------------------------------------------------------------------

        if ((dropdownToFind1.value != 0) & (dropdownToFind2.value != 0))
        {
            if (dropdownToFind1.value == 1)
                {
                    objectToFind1.GetComponent<Camera>().enabled = true;
                    objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
                    objectToFind2.GetComponent<Camera>().enabled = false;
                    objectToFind3.GetComponent<Camera>().enabled = false;

                    buttonToFind1.gameObject.SetActive(true);
                    buttonToFind1.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                    buttonToFind2.gameObject.SetActive(false);
                    buttonToFind3.gameObject.SetActive(false);

                    buttonToFind4.gameObject.SetActive(true);
                    buttonToFind4.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                    buttonToFind5.gameObject.SetActive(false);
                    buttonToFind6.gameObject.SetActive(false);


                }

                if (dropdownToFind1.value == 2)
                {
                    objectToFind2.GetComponent<Camera>().enabled = true;
                    objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
                    objectToFind1.GetComponent<Camera>().enabled = false;
                    objectToFind3.GetComponent<Camera>().enabled = false;

                    buttonToFind2.gameObject.SetActive(true);
                    buttonToFind2.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                    buttonToFind1.gameObject.SetActive(false);
                    buttonToFind3.gameObject.SetActive(false);

                    buttonToFind5.gameObject.SetActive(true);
                    buttonToFind5.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                    buttonToFind4.gameObject.SetActive(false);
                    buttonToFind6.gameObject.SetActive(false);

                }

                if (dropdownToFind1.value == 3)
                {
                    objectToFind3.GetComponent<Camera>().enabled = true;
                    objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
                    objectToFind2.GetComponent<Camera>().enabled = false;
                    objectToFind1.GetComponent<Camera>().enabled = false;

                    buttonToFind3.gameObject.SetActive(true);
                    buttonToFind3.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                    buttonToFind2.gameObject.SetActive(false);
                    buttonToFind1.gameObject.SetActive(false);

                    buttonToFind6.gameObject.SetActive(true);
                    buttonToFind6.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                    buttonToFind5.gameObject.SetActive(false);
                    buttonToFind4.gameObject.SetActive(false);
                }

            //handling screen size

            /*
            GetComponent<handle_view_screen2_copy>().objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
            GetComponent<handle_view_screen2_copy>().objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
            GetComponent<handle_view_screen2_copy>().objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.5f, 0.35f, 0.5f);
            */

        }


        //for three screen-----------------------------------------------------------------------------------------------------------------------

        if (dropdownToFind3.value != 0)
        {
            if (dropdownToFind1.value == 1)
            {
                objectToFind1.GetComponent<Camera>().enabled = true;
                objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
                objectToFind2.GetComponent<Camera>().enabled = false;
                objectToFind3.GetComponent<Camera>().enabled = false;

                buttonToFind1.gameObject.SetActive(true);
                buttonToFind1.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind2.gameObject.SetActive(false);
                buttonToFind3.gameObject.SetActive(false);

                buttonToFind4.gameObject.SetActive(true);
                buttonToFind4.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind5.gameObject.SetActive(false);
                buttonToFind6.gameObject.SetActive(false);




            }

            if (dropdownToFind1.value == 2)
            {
                objectToFind2.GetComponent<Camera>().enabled = true;
                objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
                objectToFind1.GetComponent<Camera>().enabled = false;
                objectToFind3.GetComponent<Camera>().enabled = false;

                buttonToFind2.gameObject.SetActive(true);
                buttonToFind2.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind1.gameObject.SetActive(false);
                buttonToFind3.gameObject.SetActive(false);

                buttonToFind5.gameObject.SetActive(true);
                buttonToFind5.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind4.gameObject.SetActive(false);
                buttonToFind6.gameObject.SetActive(false);

            }

            if (dropdownToFind1.value == 3)
            {
                objectToFind3.GetComponent<Camera>().enabled = true;
                objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
                objectToFind2.GetComponent<Camera>().enabled = false;
                objectToFind1.GetComponent<Camera>().enabled = false;

                buttonToFind3.gameObject.SetActive(true);
                buttonToFind3.transform.position = new Vector3(1860.0f, 1050.0f, 0.0f);
                buttonToFind2.gameObject.SetActive(false);
                buttonToFind1.gameObject.SetActive(false);

                buttonToFind6.gameObject.SetActive(true);
                buttonToFind6.transform.position = new Vector3(1760.0f, 1050.0f, 0.0f);
                buttonToFind5.gameObject.SetActive(false);
                buttonToFind4.gameObject.SetActive(false);
            }

            //handling screen size

            /*
            GetComponent<handle_view_screen2_copy>().objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
            GetComponent<handle_view_screen2_copy>().objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
            GetComponent<handle_view_screen2_copy>().objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);

            GetComponent<handle_view_screen3>().objectToFind1.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
            GetComponent<handle_view_screen3>().objectToFind2.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
            GetComponent<handle_view_screen3>().objectToFind3.GetComponent<Camera>().rect = new Rect(0.65f, 0.6666f, 0.35f, 0.3333f);
            */
        }
        

        

        /*if (dropdownToFind.value == 0)
            {
                objectToFind3.gameObject.SetActive(false);
                objectToFind2.gameObject.SetActive(false);
                objectToFind1.gameObject.SetActive(false);
            }
        */
    }
}
