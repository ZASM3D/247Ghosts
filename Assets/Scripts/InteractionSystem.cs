using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    public LayerMask ignoreMask;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact")) {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, ~ignoreMask)) {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                Debug.Log(hit.collider.gameObject);
                InteractComponent intComp = hit.collider.gameObject.GetComponent<InteractComponent>();
                if (intComp) {
                    intComp.Interact();
                }
            }
        }
    }
}
