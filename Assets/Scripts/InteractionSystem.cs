using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionSystem : MonoBehaviour
{
    public LayerMask ignoreMask;
    public float distance;
    public Image reticle;
    public Color hoverColor;

    private Color defaultColor;

    void Start() {
        defaultColor = reticle.color;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        InteractComponent intComp = null;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, ~ignoreMask)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
            intComp = hit.collider.gameObject.GetComponent<InteractComponent>();
        }

        if (intComp) {
            reticle.color = hoverColor;
            Debug.Log("Set");
        } else {
            reticle.color = defaultColor;
        }

        if (Input.GetButtonDown("Interact")) {
            if (intComp) {
                intComp.Interact();
            }
        }
    }
}
