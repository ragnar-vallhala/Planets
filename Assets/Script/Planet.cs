using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float mass = 100.0f;
    [SerializeField] private float k = 100.0f;



    // Update is called once per frame
    void Update()
    {
        Planet[] bodies = GameObject.FindObjectsOfType<Planet>();
        foreach (Planet body in bodies)
        {
            Vector3 r = body.transform.position - transform.position;
            r.Normalize();
            Vector3 accel = (k * body.mass / (r.magnitude * r.magnitude))*r;

            Vector3 velocity = accel * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;

            
        }

    }
}
