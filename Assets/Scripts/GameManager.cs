using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject activeCanvas;
    private Camera playerCamera;
    private CharactrerControl playerMove;
    private MouseLook playerLook;

    public GameObject defaultCanvas;
    public GameObject player;

    void Awake() {
        activeCanvas = defaultCanvas;
    }

    void Start() {
        playerMove = player.GetComponent<CharactrerControl>();
        playerLook = player.GetComponent<MouseLook>();
        playerCamera = Camera.main;
    }

    public void SetActiveCanvas(GameObject newCanvas) {
        activeCanvas.SetActive(false);
        activeCanvas = newCanvas;
        activeCanvas.SetActive(true);
    }

    public GameObject GetActiveCanvas() {
        return activeCanvas;
    }

    public void ResetCanvas() {
        activeCanvas.SetActive(false);
        activeCanvas = defaultCanvas;
        activeCanvas.SetActive(true);
    }

    public void DisablePlayerMovement() {
        playerMove.enabled = false;
        playerLook.enabled = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void AllowPlayerMovement() {
        playerMove.enabled = true;
        playerLook.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SetCamera(Transform view) {
        playerCamera.transform.position = view.position;
        playerCamera.transform.rotation = view.rotation;
    }

    public void ResetCamera() {
        playerCamera.transform.position = player.transform.GetChild(0).GetChild(0).position;
        playerCamera.transform.rotation = Quaternion.LookRotation(player.transform.forward);

    }
}
