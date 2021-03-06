﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Random point manager holds a list of groups of random points
/// makes it possible to create/destroy
/// other option might be mastering the art of parenting objects and use that system to manage objects (preferred)
/// </summary>
public class RandomPointManager : MonoBehaviour
{
		public Transform  pointPrefab;
		public int numberPoints = 100;
//
//	public Shader shader;
//	public bool showPointsAtStart = true;
//	private int canvasIndex = 0;
//
//	void Start ()
//	{
//		//Points = new List<GameObject> ();
//
//		if (showPointsAtStart) {
//			//GameObject pointPrefab = new GameObject. 
//			
//			//createRandomPoints(pointPrefab); gameObject.transform.position, xColor, shader, numberPoints) ;
//		}
//	}
//	private GameObject createLine (Vector3 start, Vector3 end, float lineSize, Color c)
//	{
//		return createLine (start, end, lineSize, c, shader);
//	}
//	private GameObject createLine (Vector3 start, Vector3 end, float lineSize, Color c, Shader s)
//	{
//				GameObject canvas = new GameObject ("line" + canvasIndex); 
//				canvas.transform.parent = transform;
//				canvas.transform.rotation = transform.rotation;
//				LineRenderer lines = (LineRenderer)canvas.AddComponent<LineRenderer> ();
//				lines.material = new Material (s);
//				lines.material.color = c;
//				lines.useWorldSpace = false;
//				lines.SetWidth (lineSize, lineSize);
//				lines.SetVertexCount (2);
//				lines.SetPosition (0, new Vector3 (0, 0, 0));
//				end = end - start;
//				lines.SetPosition (1, end);
//				canvas.transform.position = start;
//				canvasIndex++;
//				return canvas;
//	}
//	public void createRandomPoints (GameObject pointPrefab) 
//	{
//		createRandomPoints (pointPrefab, Vector3.one, Color.blue, shader, 100) ;
//	}
//	public void createRandomPoints (GameObject pointPrefab, Vector3 center, Color c, Shader s, int NumberPoints) 
//	{
//		GameObject canvas = new GameObject ("point" + canvasIndex); 
//		canvas.transform.parent = transform;
//		canvas.transform.rotation = transform.rotation;
//
//		for (int i = 0; i < NumberPoints; i++) {
//			Object point = Instantiate(pointPrefab, Random.insideUnitCircle, Quaternion.identity);
//			Transform t = (Transform)canvas.AddComponent("QuadPoint");
//			t.position = Random.insideUnitSphere;
//		}
//		canvas.transform.position = center;
//		canvasIndex++;
//		//return canvas;
//	}
		//...........................................................................................
	
		public List<GameObject> CreatedPoints;

		void Start ()
		{
				CreatedPoints = new List<GameObject> ();
		}
	
//	public void AddRandomPoints (Vector3 center, int numberPoints) {
//		for (int i = 0; i < numberPoints; i++) {
//			GameObject point;
//			point = Instantiate(pointPrefab, Random.insideUnitSphere, Quaternion.identity) as GameObject;
//			CreatedPoints.Add (point);
//			//this.gameObject. canvas.transform.parent = transform;
//		}
//
//	}
//	public void AddRandomPoints (Vector3 center, int numberPoints) {
//		GameObject point = new GameObject();
//		//point.AddComponent<GeneratePoints>();
//		prefabPoint = Instantiate(pointPrefab, Random.insideUnitSphere, Quaternion.identity) as GameObject;
//		point.transform.position = center;
//		CreatedPoints.Add (point);
//
//	}

		public void CreateRandomPointGroup (GameObject parentObject, int count)
		{

				GameObject prefabGroupRandomPoints = Instantiate (pointPrefab, parentObject.transform.position, Quaternion.identity) as GameObject;
				if (prefabGroupRandomPoints) {			
						prefabGroupRandomPoints.transform.parent = this.gameObject.transform;

						CreatedPoints.Add (prefabGroupRandomPoints);

	
					
				}

				//GameObject canvas = new GameObject ("canvas" + canvasIndex); 
				//canvas.transform.parent = transform;

		}

		public void ClearAllPoints ()
		{
				foreach (GameObject o in CreatedPoints) {
						Destroy (o.gameObject);
				}
		}
}
