using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;
using UnityEngine.SceneManagement;

public class ClearScript : MonoBehaviour, IInputClickHandler{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputEventData eventData)
    {
        SceneManager.LoadScene("MainScene");
    }
}
