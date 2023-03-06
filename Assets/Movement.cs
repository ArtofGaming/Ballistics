using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        gameObject.transform.position = new Vector3(transform.position.x - (h * speed * Time.deltaTime),1,transform.position.z - (v * speed * Time.deltaTime));
    }
}
