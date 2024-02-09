using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    [SerializeField]
    private GameObject arrow_object;

    // Fill a large volume with arrow vectors according to some resolution
    // Store these arrows in an arena with some maximum limit
    // Dynamically cull these vectors based on if in the camera view
    //      Event-based
    //      Store the non-culled arrows in a list?
    //      

    // Start is called before the first frame update
    void Start()
    {
        // procedurally instantiate each arrow
    }
}
