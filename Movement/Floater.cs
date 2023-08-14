using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{ 
    Vector3 positioner = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        positioner = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        positioner.y += Mathf.Sin(Time.fixedTime * Mathf.PI * 1f) * 0.005f;
        transform.position = positioner;
    }
}
