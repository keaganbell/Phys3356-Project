using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMotionController : MonoBehaviour
{
    [SerializeField]
    private float mass = 1.0f;
    [SerializeField]
    private float other_mass;
    [SerializeField]
    private Vector3 initial_velocity;
    [SerializeField]
    private Transform other_transform;

    private Vector3 velocity;
    private Vector3 momentum;
    private Vector3 force;

    // Start is called once
    void Start()
    {
        momentum = mass * initial_velocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        momentum += GetForce() * Time.deltaTime;
        transform.position += momentum / mass * Time.deltaTime;
    }
    
    Vector3 GetDisplacement()
    {
        if (!other_transform)
        {
            Debug.Log("The other transform is missing!!!");
        }

        return other_transform.position - transform.position;
    }

    Vector3 GetForce()
    {
        return mass * other_mass / (GetDisplacement().magnitude * GetDisplacement().magnitude) * GetDisplacement();
    }
}
