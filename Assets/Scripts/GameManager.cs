using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject activeCanvas;
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
}
