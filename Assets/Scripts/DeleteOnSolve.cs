using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnSolve : TriggerableObject
{
    public override void TriggerPuzzle(string name) {
        Destroy(gameObject);
    }
}
