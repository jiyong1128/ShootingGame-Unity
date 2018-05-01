using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColision : MonoBehaviour {

	void OnCollisionEnter() {
		Debug.Log ("WE hit something");
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		Debug.Log ("WE hit something");
	}
	
}
