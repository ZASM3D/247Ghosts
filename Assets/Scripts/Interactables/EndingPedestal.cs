using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingPedestal : ObjectLock
{
    public Transform newLocation;

    public override void UnlockAction() {
        GameState.Manager.DisablePlayerMovement();
        GameState.Manager.SetCamera(newLocation);
        GameState.Manager.GetActiveCanvas().SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
