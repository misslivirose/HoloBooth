using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChristmasTreeScript : MonoBehaviour, IInputClickHandler {
    public void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("I've been clicked");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
