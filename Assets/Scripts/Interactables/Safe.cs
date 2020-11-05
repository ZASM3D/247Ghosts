using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : InteractComponent
{
    private GameObject oldCanvas;
    private bool solved;
    private GameManager manager;
    public GameObject keypadCanvas;
    public Transform viewPoint;
    public GameObject door;
    public GameObject openDoor;

    void Start() {
        manager = GameState.Manager;
        solved = false;
    }

    public override void Interact() {
        if (solved) return;
        manager.SetActiveCanvas(keypadCanvas);
        manager.DisablePlayerMovement();
        if (viewPoint)
            manager.SetCamera(viewPoint);
    }

    public override void TriggerPuzzle(string name) {
        if (solved) return;
        Debug.Log("Safe opened");

        door.SetActive(false);
        openDoor.SetActive(true);
        this.transform.GetComponent<BoxCollider>().enabled = false;

        solved = true;
        FinishInteract();
    }

    public void FinishInteract() {
        if (viewPoint)
            manager.ResetCamera();

        manager.ResetCanvas();
        manager.AllowPlayerMovement();
    }
}
