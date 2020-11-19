using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject activeCanvas;
    private Camera playerCamera;
    private CharactrerControl playerMove;
    private MouseLook playerLook;
    private PlayerInventory inventory;

    public GameObject defaultCanvas;
    public GameObject notesCanvas;
    public GameObject sheetMusicCanvas;

    void Awake() {
        GameState.Manager = this;
        activeCanvas = defaultCanvas;
    }

    void Start() {
        playerMove = GameState.Player.GetComponent<CharactrerControl>();
        playerLook = GameState.Player.GetComponent<MouseLook>();
        inventory = GameState.Player.GetComponent<PlayerInventory>();
        playerCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetButtonDown("Quit")) {
            Debug.Log("Bye");
            Application.Quit();
        }

        if (activeCanvas == notesCanvas && Input.GetKeyDown(KeyCode.Escape)) {
            ResetCanvas();
            AllowPlayerMovement();
        }
    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
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
        playerCamera.transform.position = GameState.Player.transform.GetChild(0).GetChild(0).position;
        playerCamera.transform.rotation = Quaternion.LookRotation(GameState.Player.transform.forward);
    }

    public void LoadNote(string text) {
        SetActiveCanvas(notesCanvas);
        Text noteBody = notesCanvas.transform.GetChild(1).GetComponent<Text>();
        noteBody.text = text;
    }

    public void LoadSheetMusic() {
        SetActiveCanvas(sheetMusicCanvas);
    }

    public void UnloadNote() {
        ResetCanvas();
        AllowPlayerMovement();
    }

    public bool CheckPlayerHasItem(string item) {
        return inventory.HasItem(item);
    }

    public void GivePlayerItem(string item) {
        if (!inventory.HasItem(item))
            inventory.AddItem(item);
    }

    public void RemoveItem(string item) {
        if (inventory.HasItem(item))
            inventory.RemoveItem(item);
    }
}
