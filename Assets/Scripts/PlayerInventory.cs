using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private HashSet<string> heldItems;

    public void AddItem(string item) {
        heldItems.Add(item);
    }

    public bool HasItem(string item) {
        return heldItems.Contains(item);
    }

    public void RemoveItem(string item) {
        heldItems.Remove(item);
    }
}
