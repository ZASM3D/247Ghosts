using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSettingPuzzle : InteractComponent
{
    private GameManager manager;
    public GameObject secret;
    public GameObject prompt;
    public GameObject foundSpoon;
    public string requiredObject;

    void Start() {
        manager = GameState.Manager;
        prompt.SetActive(true);
        secret.SetActive(false);
        foundSpoon.SetActive(false);
    }

    public override void Interact() {
    	if (GameState.Manager.CheckPlayerHasItem(requiredObject)) {
            GameState.Manager.RemoveItem(requiredObject);
            Debug.Log("Unlocked with " + requiredObject);
            foundSpoon.SetActive(true);
            prompt.SetActive(false);
        	secret.SetActive(true);
        }
    }
}