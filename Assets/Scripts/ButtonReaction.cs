using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonReaction : MonoBehaviour
{
    public KeypadControl control;
    public Button triggerButton;
    public char value;

    void Start()
    {
        triggerButton.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (value == 'E') {
            control.CheckValue();
            return;
        }
        control.AddChar(value);
    }
}
