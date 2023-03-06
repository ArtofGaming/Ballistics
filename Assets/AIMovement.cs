using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public AIThrow throwable;
    public bool takingAction = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!takingAction)
        {
            if (!throwable.hasBall)
            {
                transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("ball").transform.position, .01f);
            }
        }
        
    }
}
