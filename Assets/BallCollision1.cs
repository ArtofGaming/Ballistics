using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision1 : MonoBehaviour
{
    public Throw throwing;
    public Health hp;
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
        if(collision.gameObject.tag == "ball")
        {
            throwing.hasBall = true;
            throwing.throwable = collision.gameObject;
            collision.gameObject.transform.parent = GameObject.Find("Player").transform;
            collision.gameObject.tag = "projectile";

        }
        else if (collision.gameObject.tag == "projectile")
        {
            hp.health -= 1;
            collision.gameObject.tag = "ball";
        }
    }
}
