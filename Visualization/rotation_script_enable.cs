using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_script_enable : MonoBehaviour
{
    public void whenButtonClicked()
    {

        if ((GetComponent<PointcloudController>().enabled) == false)
            GetComponent<PointcloudController>().enabled = true;

        else
            GetComponent<PointcloudController>().enabled = false;
    }
}
