using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class blade_rot : MonoBehaviour
{
    public Vector3 rotationVector;
    private void Update()
    {
        transform.Rotate(rotationVector * Time.deltaTime);
    }
}
