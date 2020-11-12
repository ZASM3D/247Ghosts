using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : InteractComponent
{
	private GameManager manager;
    public GameObject[] lilyText;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject g in lilyText) {
        	g.SetActive(false);
        }
        lilyText[0].SetActive(true);
        index = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact() {
        manager.DisablePlayerMovement();
        if (index > 0) {
        	lilyText[index - 1].SetActive(false);
        }
    	lilyText[index].SetActive(true);
    	index = (index + 1) % lilyText.Length;
    }
}
