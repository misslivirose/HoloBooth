using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class AddHologram : MonoBehaviour, IInputClickHandler {

    public GameObject HoloGramToInstantiate;
    GameObject NewHologram;

    public void OnInputClicked(InputEventData eventData)
    {
        NewHologram = Instantiate(HoloGramToInstantiate);
        NewHologram.AddComponent<BoxCollider>();
        NewHologram.AddComponent<HologramPlacement>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
