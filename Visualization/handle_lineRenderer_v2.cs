using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handle_lineRenderer_v2 : MonoBehaviour
{
    public GameObject CameraToFind;
    public GameObject PointCloudToFind;

    private new Camera camera;

    public Material lineMaterial;
    public float lineWidth;
    public float depth = 5;

    private Vector3? lineStartPoint = null;
    private Vector3? lineEndPoint;

    private Vector3 start_update;
    private Vector3 end_update;

    // Update is called once per frame
    void Update()
    {
        //pos = CubeToFind.transform.position;
        camera = CameraToFind.GetComponent<Camera>();
        //camera.orthographic = true;
        camera.orthographic = true;

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

            
            lineEndPoint = GetMouseCameraPoint();
            var gameObject = new GameObject();
            var lineRenderer = gameObject.AddComponent<LineRenderer>();
            lineRenderer.material = lineMaterial;
     
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

            lineRenderer.SetPositions(new Vector3[] { start_update, end_update });
            lineRenderer.useWorldSpace = false;
            lineRenderer.startWidth = lineWidth;
            lineRenderer.endWidth = lineWidth;


            //Physics.gravity = new Vector3(0, 0, 0);
            if (PointCloudToFind.GetComponent<Rigidbody>() != null)
            {
                var rigidbody_pc = PointCloudToFind.GetComponent<Rigidbody>();
                rigidbody_pc.isKinematic = true;
            }

            else
            {
                var rigidbody_pc = PointCloudToFind.AddComponent<Rigidbody>();
                rigidbody_pc.isKinematic = true;
            }

            //var fixedjoint_pc = PointCloudToFind.AddComponent<FixedJoint>();

            //rigidbody_pc.isKinematic = true;

            Physics.gravity = new Vector3(0, 0, -20f);

            var rigidbody_lr = gameObject.AddComponent<Rigidbody>();
            var boxcollider_lr = gameObject.AddComponent<BoxCollider>();
            boxcollider_lr.size = new Vector3(0.5f, 0f, 0f);

            StartCoroutine(ExecuteAfterTime(2f, gameObject, PointCloudToFind));

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

    IEnumerator ExecuteAfterTime(float time, GameObject GameObject_line, GameObject GameObject_pc)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        var rigidbody_lr = GameObject_line.GetComponent<Rigidbody>();
        var rigidbody_pc = GameObject_pc.GetComponent<Rigidbody>();
        var fixedjoint_pc = GameObject_pc.AddComponent<FixedJoint>();
        //var fixedjoint_pc = GameObject_pc.GetComponent<FixedJoint>();

        rigidbody_lr.isKinematic = true;

        //rigidboy_pc.isKinematic = true;

        fixedjoint_pc.connectedBody = rigidbody_lr;

        rigidbody_lr.isKinematic = false;

        this.enabled = false;
        GameObject.Find("DrawLineButton").GetComponentInChildren<Text>().text = "Enable Draw Line";
        GetComponent<handle_lineRenderer_v2>().CameraToFind.GetComponent<Camera>().orthographic = false;
        //Physics.gravity = new Vector3(0, 0, 0);
    }
}
