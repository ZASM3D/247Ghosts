using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteRiddle : InteractComponent
{
    private bool solved;
    private GameManager manager;
    public GameObject keypadCanvas;
    public Transform viewPoint;
    public GameObject note;
    public GameObject secret;
    public GameObject prompt;


    void Start() {
        manager = GameState.Manager;
        solved = false;
        note.SetActive(true);
        secret.SetActive(false);
        prompt.SetActive(true);
        //manager.ResetCanvas();
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
        Debug.Log("Riddle solved");

        //note.SetActive(false);
        secret.SetActive(true);
        prompt.SetActive(false);
       // this.transform.GetComponent<BoxCollider>().enabled = false;

        solved = true;
        FinishInteract();
    }

    public override void FinishInteract() {
        if (viewPoint)
            manager.ResetCamera();

        manager.ResetCanvas();
        manager.AllowPlayerMovement();
    }
}
