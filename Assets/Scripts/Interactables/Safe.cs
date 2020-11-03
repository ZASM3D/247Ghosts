using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : InteractComponent
{
    private GameObject oldCanvas;
    private bool solved;
    private GameManager manager;
    public GameObject keypadCanvas;
    public Material unlockedMaterial;
    public Transform viewPoint;

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
        Debug.Log("Safe opened");

        if (unlockedMaterial)
            GetComponent<Renderer>().material = unlockedMaterial;

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
