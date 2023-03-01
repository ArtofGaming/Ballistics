using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ballistics
{
    Vector3 result;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3? CalculateFiringSolution(Vector3 start, Vector3 end, float muzzleV, Vector3 gravity)
    {
        Vector3 delta = end - start;
        var a = gravity.magnitude *gravity.magnitude;
        var b = -4 * (Vector3.Dot(gravity, delta) + muzzleV * muzzleV);
        var c = 4 * delta.magnitude *delta.magnitude;
        float b2minus4ac = (b * b) - (4 * a * c);
        if (b2minus4ac < 0)
        {
            return null;
        }

        float time0 = Mathf.Sqrt((-b + Mathf.Sqrt(b2minus4ac)) / (2 * a));
        float time1 = Mathf.Sqrt((-b - Mathf.Sqrt(b2minus4ac)) / (2 * a));
        Debug.Log(time0);
        Debug.Log(time1);
        float ttt = 0;
        if (time0 < 0)
        {
            if (time1 < 0)
            {
                return null;
            }
            else
            {
                ttt = time1;
            }
        }
        else
        {
            if (time1 < 0)
            {
                ttt = time0;
            }
            else
            {
                ttt = Mathf.Min(time0, time1);
            }
        }
        result = ((delta * 2) - (gravity * (ttt * ttt))) / (2 * muzzleV * ttt);
        Debug.Log(ttt);
        return result;

        
    }
}
