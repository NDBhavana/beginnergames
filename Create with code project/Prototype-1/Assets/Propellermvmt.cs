using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellermvmt : MonoBehaviour

{public float rotationspeed=200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward,rotationspeed);
    }
}
