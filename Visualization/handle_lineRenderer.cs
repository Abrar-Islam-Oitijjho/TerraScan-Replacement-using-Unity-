using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class handle_lineRenderer : MonoBehaviour
{
    private new Camera camera;
    public GameObject CubeToFind;

    public Material lineMaterial;
    public float lineWidth;
    public float depth = 5;

    private Vector3? lineStartPoint = null;
    private Vector3? lineEndPoint;

    private Vector3 start_update;
    private Vector3 end_update;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = CubeToFind.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            lineStartPoint = GetMouseCameraPoint();
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!lineStartPoint.HasValue)
            {
                return;
            }

            //var lineEndPoint = GetMouseCameraPoint();
            lineEndPoint = GetMouseCameraPoint();
            var gameObject = new GameObject();
            var lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.material = lineMaterial;

            start_update = lineStartPoint.Value;
            end_update = lineEndPoint.Value;
            start_update.z = pos.z;
            end_update.z = pos.z;
         
            lineRenderer.SetPositions(new Vector3[] { start_update, end_update });
            lineRenderer.startWidth = lineWidth;
            lineRenderer.endWidth = lineWidth;

            //lineStartPoint = null;

            Debug.Log("Start = " + start_update);
            Debug.Log("mouse_start = " + lineStartPoint);
            Debug.Log("cube " + pos);
        }
    }

    private Vector3? GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        return ray.origin + ray.direction * depth;
    }
}


/* version 2 copy with comment
 * 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handle_lineRenderer_v2 : MonoBehaviour
{

    private new Camera camera;
    //public GameObject CubeToFind;

    public Material lineMaterial;
    public float lineWidth;
    public float depth = 5;

    private Vector3? lineStartPoint = null;
    private Vector3? lineEndPoint;

    private Vector3 start_update;
    private Vector3 end_update;
    //private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //pos = CubeToFind.transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            lineStartPoint = GetMouseCameraPoint();
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (!lineStartPoint.HasValue)
            {
                return;
            }

            //var lineEndPoint = GetMouseCameraPoint();
            lineEndPoint = GetMouseCameraPoint();
            var gameObject = new GameObject();
            var lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.material = lineMaterial;
            //gameObject.transform.position = new Vector3(-200.0f, 200.0f, 192.0f);
            //lineRenderer.positionCount = 2;
            //lineStartPoint.Value.z = -2.5f;
            //lineEndPoint.Value.z = -2.5f;
            start_update = lineStartPoint.Value;
            end_update = lineEndPoint.Value;

            if (start_update.z > end_update.z)
            {
                start_update.z = end_update.z;
            }

            if (start_update.z < end_update.z)
            {
                end_update.z = start_update.z;
            }

            //pos = CubeToFind.transform.position;
            //Debug.Log("cube " + pos);

            //start_update = lineStartPoint.Value;
            //end_update = lineEndPoint.Value;
            //start_update.z = pos.z;
            //end_update.z = pos.z;
            //Debug.Log("cube " + pos);
            //start_update.y  lineStartPoint.Value.x;
            //lineRenderer.SetPositions(new Vector3[] {lineStartPoint.Value, lineEndPoint.Value}) ;
            lineRenderer.SetPositions(new Vector3[] { start_update, end_update });
            lineRenderer.useWorldSpace = false;
            var rigidboy = gameObject.AddComponent<Rigidbody>();
            var boxcollider = gameObject.AddComponent<BoxCollider>();
            boxcollider.size = new Vector3(0.5f, 0f, 0f);
            lineRenderer.startWidth = lineWidth;
            lineRenderer.endWidth = lineWidth;

            //lineStartPoint = null;

            //Debug.Log("Start = " + start_update);
            //Debug.Log("End = " + lineStartPoint);
            //Debug.Log("cube " + pos);
        }
    }

    private Vector3? GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        return ray.origin + ray.direction * depth;
    }
}
*/

