using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public AIThrow throwing;
    public Health hp;
    public AIMovement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if(collision.gameObject.tag == "ball")
        {
            throwing.hasBall = true;
            movement.takingAction = true;
            throwing.throwable = collision.gameObject;
            collision.gameObject.transform.parent = GameObject.Find("Hands").transform;
            collision.gameObject.tag = "projectile";

        }
        else if (collision.gameObject.tag == "projectile")
        {
            hp.health -= 1;
            collision.gameObject.tag = "ball";
        }
    }
}
