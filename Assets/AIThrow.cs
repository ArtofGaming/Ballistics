using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class AIThrow : MonoBehaviour
{
    public Rigidbody rb;
    public Transform target;
    float launchForce = 10f;
    public GameObject throwable;
    public bool hasBall = false;
    float timer = 10f;
    public AIMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (hasBall && timer >= 10)
        {
            Throw();
        }
    }

    public void Throw()
    {
        rb = throwable.GetComponent<Rigidbody>();
        Ballistics ball = new Ballistics();
        Nullable<Vector3> aimVector = ball.CalculateFiringSolution(throwable.transform.position, target.transform.position, launchForce, Physics.gravity);
        if (aimVector.HasValue)
        {
            rb.AddForce(aimVector.Value.normalized * launchForce, ForceMode.VelocityChange);
            rb.useGravity = true;
            hasBall = false;
            movement.takingAction = false;
        }
    }

}
