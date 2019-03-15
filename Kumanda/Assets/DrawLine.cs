using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DrawLine : MonoBehaviour {
    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public Transform orgin;
    public Transform destination;

    public float lineDrawSpeed = 6f;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, orgin.position);
        lineRenderer.SetWidth(2f, 2f);

        dist = Vector3.Distance(orgin.position, destination.position);
	}
	
	// Update is called once per frame
	void Update () {
		if(counter<dist)
        {
            counter+=.1f/lineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = orgin.position;
            Vector3 pointB = destination.position;
            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPosition(1, pointAlongLine);
        }
	}
}
