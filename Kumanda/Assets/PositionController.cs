using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionController : MonoBehaviour {
    public Camera cameraTransform;
    public float distanceFromCamera;
    void Update()
    {
        Vector3 pos = cameraTransform.WorldToViewportPoint(transform.position);
        transform.position = cameraTransform.ViewportToWorldPoint(pos);

    }
}
