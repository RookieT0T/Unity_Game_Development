using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid_Rotation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * 40f);
    }
}
