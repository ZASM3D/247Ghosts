using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSettingPuzzle : ObjectLock
{
    private GameManager manager;
    public GameObject secret;
    public GameObject prompt;
    public GameObject foundSpoon;

    void Start() {
        manager = GameState.Manager;
        prompt.SetActive(true);
        secret.SetActive(false);
        foundSpoon.SetActive(false);
        removeObjects = true;
    }

    public override void UnlockAction() {
        foundSpoon.SetActive(true);
        prompt.SetActive(false);
        secret.SetActive(true);
    }
}
