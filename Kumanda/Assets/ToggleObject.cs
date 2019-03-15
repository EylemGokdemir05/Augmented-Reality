using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour {
    public GameObject[] objects;

	// Use this for initialization
	void Start ()
    {
        foreach (GameObject go in objects)
        {
            //go.GetComponent<MeshRenderer>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
