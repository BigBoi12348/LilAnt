using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = cameraPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
