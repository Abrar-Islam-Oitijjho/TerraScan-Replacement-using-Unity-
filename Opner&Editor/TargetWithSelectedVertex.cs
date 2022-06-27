using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using UnityEngine;

public class TargetWithSelectedVertex : MonoBehaviour
{

    //public Vector3 start_end_co_ordinates;
    public int choice = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var gameobject_selected_vertex = gameObject.name;
            var lineRenderer_selected_vertex = gameObject.GetComponent<LineRenderer>();
            var connector_gameobject = GameObject.Find("LineConnector");

            string[] line_vertex_info = gameobject_selected_vertex.Split('_');
            Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
            //Match result__line_name = re.Match(line_vertex_info[0]);
            Match result__vertex_numeber = re.Match(line_vertex_info[1]);

            connector_gameobject.GetComponent<LineConnectorWithVertex>().selected_line_name = line_vertex_info[0];
            connector_gameobject.GetComponent<LineConnectorWithVertex>().selected_vertex_number = Int32.Parse(result__vertex_numeber.Groups[2].Value);

            //Debug.Log(result_name.Groups[3].Value);

            Vector3 vertex_co_ordinate = lineRenderer_selected_vertex.GetPosition(1);


            if (choice == 0)
            {
                if (connector_gameobject.GetComponent<LineConnectorWithVertex>().initial_start_co_ordinate.x == 0.0f)
                {
                    connector_gameobject.GetComponent<LineConnectorWithVertex>().initial_start_co_ordinate = vertex_co_ordinate;
                }

                else
                {
                    connector_gameobject.GetComponent<LineConnectorWithVertex>().initial_end_co_ordinate = vertex_co_ordinate;
                }
            }

            if (choice == 1)
            {
                Debug.Log("OnProgress");
            }




            //start_end_co_ordinates = test2;

                //var gameObject_vertex_connector = new GameObject();
                //Debug.Log(test3);
                //Debug.Log(start_end_co_ordinates[0]);
                //Debug.Log(start_end_co_ordinates[1]);

        }
    }
}
