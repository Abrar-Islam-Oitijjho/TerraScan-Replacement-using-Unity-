using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_cloud_importer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string[] lines_x = System.IO.File.ReadAllLines("xoffset_pointcloud2.txt");
        string[] lines_y = System.IO.File.ReadAllLines("yoffset_pointcloud2.txt");
        string[] lines_z = System.IO.File.ReadAllLines("zoffset_pointcloud2.txt");

        string[] co_ordiantes_x = lines_x[0].Split(' ');
        string[] co_ordiantes_y = lines_y[0].Split(' ');
        string[] co_ordiantes_z = lines_z[0].Split(' ');

        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        for (int point = 0; point < 1000000; point++)
        {
            //var gameObject = new GameObject();
            //var lineRenderer = gameObject.AddComponent<LineRenderer>();

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(float.Parse(co_ordiantes_x[point]), float.Parse(co_ordiantes_y[point]), float.Parse(co_ordiantes_z[point]));
            cube.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            //var exp = sphere.GetComponent<SphereCollider>();
            //Destroy(exp);
        }
        

        //Debug.Log(co_ordiantes_x.Length);
    }
}
