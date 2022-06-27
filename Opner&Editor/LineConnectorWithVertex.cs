//using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;


public class LineConnectorWithVertex : MonoBehaviour
{
    public Vector3 initial_start_co_ordinate;
    public Vector3 initial_end_co_ordinate;
    
    public string selected_line_name;
    public int selected_vertex_number;

    private GameObject selected_gameobject_line;
    private int vertex_num;
    private LineRenderer selected_line_renderer;
    private int flag = 0;

    private float lineWidth_lineConnector = 0.02f;
    private Material defaultMaterial_lineConnector;

    private int choice2 = 0;
    private Vector3 hit_point;
    private GameObject gameObject_new_vertex;
    private Vector3 initial_selected_vertex_co_ordinate;

    // Start is called before the first frame update
    void Start()
    {
        var path_default_lineConnector = "Assets/Materials/Object@Default.mat";
        defaultMaterial_lineConnector = AssetDatabase.LoadAssetAtPath<Material>(path_default_lineConnector);
    }

    // Update is called once per frame
    void Update()
    {
        if (choice2 == 0)
        {
            if (initial_start_co_ordinate.x != 0.0f & initial_end_co_ordinate.x != 0.0f)
            {
                //Debug.Log(initial_start_co_ordinate.x);
                var line_connector = gameObject.AddComponent<LineRenderer>();
                line_connector.startWidth = lineWidth_lineConnector;
                line_connector.endWidth = lineWidth_lineConnector;
                line_connector.material = defaultMaterial_lineConnector;

                initial_start_co_ordinate.y = initial_start_co_ordinate.y - 0.025f;
                initial_end_co_ordinate.y = initial_end_co_ordinate.y - 0.025f;

                line_connector.SetPositions(new Vector3[] { initial_start_co_ordinate, initial_end_co_ordinate });

                this.enabled = false;
            }

            //if (Input.GetMouseButtonDown(2) & Input.GetKey(KeyCode.LeftShift))
            //{

            //}
        }

        if (choice2 == 1)
        {
            
            if (Input.GetMouseButtonDown(0) & Input.GetKey(KeyCode.LeftShift))
            {

                if (flag == 0)
                {
                    selected_gameobject_line = GameObject.Find(selected_line_name);
                    selected_line_renderer = selected_gameobject_line.GetComponent<LineRenderer>();
                    vertex_num = selected_vertex_number;
                    initial_selected_vertex_co_ordinate = selected_line_renderer.GetPosition(vertex_num);
                }

                flag = 1;
                //Vector3 mousePos = Input.mousePosition;
                //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                RaycastHit hit = new RaycastHit();

                if (Physics.Raycast(ray, out hit))
                {
                    hit_point = hit.point;
                }

                //Debug.Log(hit_point.x);
                //Debug.Log(hit_point.y);
                //Debug.Log(hit_point.z);

                selected_line_renderer.SetPosition(vertex_num, new Vector3(hit_point.x, hit_point.y, hit_point.z));
            }

            if (Input.GetMouseButtonDown(2) & Input.GetKey(KeyCode.LeftShift))
            {
                gameObject_new_vertex = new GameObject();
                var lineRenderer_new_vertex = gameObject_new_vertex.AddComponent<LineRenderer>();
                Vector3 start_update_new_vertex = new Vector3(hit_point.x, hit_point.y - 0.025f, hit_point.z);
                Vector3 end_update_new_vertex = new Vector3(hit_point.x, hit_point.y + 0.025f, hit_point.z);

                lineRenderer_new_vertex.SetPositions(new Vector3[] { start_update_new_vertex, end_update_new_vertex });
                lineRenderer_new_vertex.startWidth = lineWidth_lineConnector + 0.03f;
                lineRenderer_new_vertex.endWidth = lineWidth_lineConnector + 0.03f;

                gameObject_new_vertex.name = "Edited_" + selected_gameobject_line.name + "_" + "Vertex" + vertex_num.ToString();
            }

            if (Input.GetMouseButtonDown(1) & Input.GetKey(KeyCode.LeftShift))
            {
                Destroy(gameObject_new_vertex);
                selected_line_renderer.SetPosition(vertex_num, initial_selected_vertex_co_ordinate);
            }
        }
    }
}
