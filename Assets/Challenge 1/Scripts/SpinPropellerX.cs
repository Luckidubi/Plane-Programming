using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotateSpeed = 3000.0f;
    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotates the propeller in a given axis
        propeller.transform.Rotate(Vector3.forward * rotateSpeed, Space.Self);
    }
}
