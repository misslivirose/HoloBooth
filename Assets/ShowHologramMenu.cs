using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class ShowHologramMenu : MonoBehaviour, IInputClickHandler {

    public GameObject childCanvas;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("I've been clicked and this is when I'll open my menu!");
        childCanvas.SetActive(!childCanvas.active);
    }
}
