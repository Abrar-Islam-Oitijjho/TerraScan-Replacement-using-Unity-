using UnityEngine;
//using UnityEngine.Rendering;
using UnityEditor;
//using UnityEditor.Experimental.AssetImporters;

using System;
using System.Collections.Generic;
//using System.IO;
//using System.Linq;

/// <summary>
/// This script selects the line individually and also shows the vertices and add mesh to them.
/// </summary>

public class TargetWithVertex : MonoBehaviour
{
    //private MeshRenderer selectrenderer;
    private LineRenderer selectrenderer;
    private Vector3 start_update;
    private Vector3 end_update;
    private float lineWidth = 0.05f;
    private GameObject gameObject_vertex;

    private int vertex_count;
 
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    

    void Start()
    {
        selectrenderer = GetComponent<LineRenderer>();
        var path_default = "Assets/Materials/Object@Default.mat";
        var path_highlight = "Assets/Materials/Object@Selected.mat";

        defaultMaterial = AssetDatabase.LoadAssetAtPath<Material>(path_default);
        highlightMaterial = AssetDatabase.LoadAssetAtPath<Material>(path_highlight);

    }

    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            var gameobject_line = gameObject.name;
            //Debug.Log(gameobject_line);
            var lineRenderer_main = gameObject.GetComponent<LineRenderer>();
            selectrenderer.material = highlightMaterial;

            Vector3[] indexes = new Vector3[lineRenderer_main.positionCount];
            //Debug.Log(indexes[0]);
            int test = lineRenderer_main.GetPositions(indexes);
            //Debug.Log(indexes[0]);

            vertex_count = lineRenderer_main.positionCount;

            for (int vertex = 0; vertex < vertex_count; vertex++)
            {
                gameObject_vertex = new GameObject();
                var lineRenderer_vertex = gameObject_vertex.AddComponent<LineRenderer>();

                start_update = new Vector3(indexes[vertex].x, indexes[vertex].y - 0.025f, indexes[vertex].z);
                //Debug.Log(indexes[vertex]);
                end_update = new Vector3(indexes[vertex].x, indexes[vertex].y + 0.025f, indexes[vertex].z);

                lineRenderer_vertex.SetPositions(new Vector3[] { start_update, end_update });
                lineRenderer_vertex.startWidth = lineWidth;
                lineRenderer_vertex.endWidth = lineWidth;

                MeshCollider meshCollider_vertex = gameObject_vertex.AddComponent<MeshCollider>();
                Mesh mesh_vertex = new Mesh();
                lineRenderer_vertex.BakeMesh(mesh_vertex, true);
                meshCollider_vertex.sharedMesh = mesh_vertex;

                gameObject_vertex.name = gameobject_line + "_" + "Vertex" + vertex.ToString();
                gameObject_vertex.AddComponent<TargetWithSelectedVertex>();

            }

            //var connector_gameobject_line = GameObject.Find("LineConnector");
            //connector_gameobject_line.GetComponent<LineConnectorWithVertex>().selected_line = gameobject_line;

            //Debug.Log(gameObject_vertex.name);

        }

        if (Input.GetMouseButtonDown(1))
        {
            selectrenderer.material = defaultMaterial;

            for (int vertex = 0; vertex < vertex_count; vertex++)
            {
                Destroy(GameObject.Find(gameObject.name + "_" + "Vertex" + vertex.ToString()));
            }

            //Debug.Log(gameObject.name);
        }

    }

    /*
    private void OnMouseExit()
    {
        selectrenderer.material = defaultMaterial;
    }
    */
}