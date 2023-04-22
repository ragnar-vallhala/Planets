using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float mass = 100000000.0f;
    [SerializeField] private float k = 100.0f;



    // Update is called once per frame
    void Update()
    {
        Planet[] bodies = GameObject.FindObjectsOfType<Planet>();
        foreach (Planet body in bodies)
        {
            Vector3 r = body.transform.position - transform.position;
            
            float accel = (k * body.mass / (r.magnitude * r.magnitude));

            r.Normalize();

            Vector3 acc = accel * r;

            Vector3 velocity = acc * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;

            
        }

    }
}
