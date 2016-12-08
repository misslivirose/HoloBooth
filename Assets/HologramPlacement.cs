using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class HologramPlacement : MonoBehaviour, IInputClickHandler {

    public bool GotTransform { get; private set; }
    // Use this for initialization
    void Start () {
        GazeManager.Instance.HitObject = gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (!GotTransform)
        {
            transform.position = Vector3.Lerp(transform.position, ProposeTransformPosition(), 0.2f);
        }
    }

    Vector3 ProposeTransformPosition()
    {
        // Put the model 2m in front of the user.
        Vector3 retval = Camera.main.transform.position + Camera.main.transform.forward * 2;
        return retval;
    }

    public void OnInputClicked(InputEventData eventData)
    {
        // Note that we have a transform.
        GotTransform = true;
        GazeManager.Instance.HitObject = null;
    }
}
