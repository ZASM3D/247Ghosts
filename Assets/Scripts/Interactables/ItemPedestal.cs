using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPedestal : ObjectLock
{
    public BookCase bookCase;
    public GameObject unlockItem;

    void Start() {
        unlockItem.SetActive(false);
    }

    public override void UnlockAction() {
        unlockItem.SetActive(true);
        bookCase.IncrementCount();
    }
}
