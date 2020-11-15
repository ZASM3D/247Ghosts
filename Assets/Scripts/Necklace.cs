using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Necklace : InteractComponent
{
    public string nextScene;

    void Start() {
        Debug.Log(SceneManager.GetActiveScene().name);
    }

    public override void Interact() {
        SceneManager.LoadScene(nextScene);
    }
}
