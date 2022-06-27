using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script loads all the lines and adds mesh to them.
/// </summary>
/// 
public class TargetAll : MonoBehaviour
{
	// Start is called before the first frame update
	public float lineWidth;
	public Material lineMaterial;

	void Start()
	{
		string[] lines_x = System.IO.File.ReadAllLines("test_xoffset1.txt");
		string[] lines_y = System.IO.File.ReadAllLines("test_yoffset1.txt");
		string[] lines_z = System.IO.File.ReadAllLines("test_zoffset1.txt");

		//Debug.Log(lines_x);

		for (int line_number = 0; line_number < lines_x.Length; line_number++)
		{
			string[] co_ordiantes_x = lines_x[line_number].Split(' ');
			string[] co_ordiantes_y = lines_y[line_number].Split(' ');
			string[] co_ordiantes_z = lines_z[line_number].Split(' ');

			var gameObject = new GameObject();
			gameObject.name = "Line" + line_number.ToString();
			var lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer.positionCount = co_ordiantes_x.Length;
			lineRenderer.startWidth = lineWidth;
			lineRenderer.endWidth = lineWidth;
			lineRenderer.material = lineMaterial;

			for (int vertice = 0; vertice < lineRenderer.positionCount; vertice++)
			{
				lineRenderer.SetPosition(vertice, new Vector3(float.Parse(co_ordiantes_x[vertice]), float.Parse(co_ordiantes_y[vertice]), float.Parse(co_ordiantes_z[vertice])));
			}

			MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();
			Mesh mesh = new Mesh();
			lineRenderer.BakeMesh(mesh, true);
			meshCollider.sharedMesh = mesh;

			//gameObject.AddComponent<Target>();
			gameObject.AddComponent<TargetWithVertex>();

		}

	}

}
