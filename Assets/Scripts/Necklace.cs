using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necklace : InteractComponent
{
    public string nextScene;
    
    public override void Interact() {
        GameState.Manager.LoadScene(nextScene);
    }
}
