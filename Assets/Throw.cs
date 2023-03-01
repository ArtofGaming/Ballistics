using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Throw : MonoBehaviour
{
    public Rigidbody rb;
    public Transform target;
    float launchForce = 10f;
    public GameObject throwable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject throwMe = GameObject.Instantiate(throwable);
            Ballistics ball = new Ballistics();
            rb = throwMe.GetComponent<Rigidbody>();
            Nullable<Vector3> aimVector = ball.CalculateFiringSolution(throwMe.transform.position, target.transform.position, launchForce, Physics.gravity);
            if (aimVector.HasValue)
            {
                Debug.Log("Has Value");
                rb.AddForce(aimVector.Value.normalized * launchForce, ForceMode.VelocityChange);
                rb.useGravity = true;
            }
        }
    }

}
