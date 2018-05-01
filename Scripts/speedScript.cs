using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedScript : MonoBehaviour {
	protected Animator myAnimation;
	// Use this for initialization
	void Start () {
		myAnimation = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		myAnimation.SetFloat ("speed", Input.GetAxis ("Vertical"));
	}
}
