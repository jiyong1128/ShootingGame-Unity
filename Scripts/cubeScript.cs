using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cubeScript : MonoBehaviour {

	float speed = 200f;
	float damage = 5f;

	
	// Update is called once per frame
	public void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * speed);
	}

	void OnTriggerEnter(Collider other) {
		other.gameObject.GetComponent<Target1> ().TakeDamage(damage);
	}

//	void OnTriggerEnter( Collider other ) {
//		if ( other.GetComponent( Player ) ) {
//			other.GetComponent( Player ).health -= damageDone;
//		}
//	}
//}
}
