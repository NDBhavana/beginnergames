using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=20;
    private float turnspeed=5;
    private float horizontalinput;
    private float forwardinput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move vehicle forward
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardinput);
        transform.Rotate(Vector3.up,turnspeed*horizontalinput*Time.deltaTime);
    }
}
