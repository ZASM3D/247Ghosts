using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class CharactrerControl : MonoBehaviour
{
    private CharacterController controller;
    private string strafeInput = "Horizontal";
    private string forwardInput = "Vertical";
    private Vector3 velocity;

    public float gravity = -9.8f;
    public float speed = 5.0f;

    void Awake() {
        GameState.Player = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Quit")) {
            Debug.Log("Bye");
            Application.Quit();
        }

        float x = Input.GetAxis(strafeInput);
        float z = Input.GetAxis(forwardInput);
        Vector3 moveDirection = transform.right * x + transform.forward * z;

        controller.Move(moveDirection * Time.deltaTime * speed);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
