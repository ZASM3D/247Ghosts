using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearObject : ObjectLock
{
    private GameManager manager;
    //public GameObject toAppear;

    void Start() {
        manager = GameState.Manager;
        this.gameObject.SetActive(true);
        //toAppear.SetActive(false);
    }

    public override void UnlockAction() {
    	Debug.Log(this.transform.position);
    	Vector3 position = this.transform.position;
    	position.y += 4;
    	this.transform.position = position;
        // toAppear.SetActive(true);
        // this.gameObject.SetActive(false);
    }
}
