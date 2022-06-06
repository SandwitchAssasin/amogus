using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chese : MonoBehaviour
{
    public Vector3 sus;
    void Update()
    {
        transform.Rotate(sus.x*Random.Range(0.5f,2), sus.y * Random.Range(0.5f, 2), sus.z * Random.Range(0.5f, 2));
    }
}
