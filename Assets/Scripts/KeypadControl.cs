using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadControl : MonoBehaviour
{
    private string currentValue;
    public int length;
    public string key;
    public TriggerableObject trigger;
    public string puzzleName;
    public Text display;

    void Start()
    {
        ResetValue();
    }

    void UpdateDisplay() {
        if (display) {
            display.text = currentValue;
        }
    }

    public void AddChar(char c) {
        string firstThree = currentValue.Substring(1, length - 1);
        currentValue = firstThree + c;
        UpdateDisplay();
        Debug.Log(currentValue);
    }

    public void CheckValue() {
        Debug.Log(currentValue);
        if (currentValue.Equals(key)) {
            trigger.TriggerPuzzle(puzzleName);
        }
        ResetValue();
    }

    public void ResetValue() {
        currentValue = new string('*', length);
        UpdateDisplay();
    }
}
