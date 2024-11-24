using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider Other)
    {
        Other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider Other)
    {
        Other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
