
using UnityEngine;

public class Gun : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float impactForce = 30f;
	public float fireRate = 15f;
	public Camera fpsCam;
	public ParticleSystem muzzleFlash; 
	public GameObject impactEffect;

	// Update is called once per frame

	private float nextTimeToFire = 0f;

	void Update () {

		if (Input.GetButton ("Fire1") && Time.time >= nextTimeToFire) {
			// all the shooting code
			nextTimeToFire = Time.time + 1f/fireRate;
			Shoot();
		}
	} 
	void Shoot () {

		muzzleFlash.Play ();
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
			// only occurs if we hit something with raycast.
			Debug.Log(hit.transform.name);

			EndScript targetBoss = hit.transform.GetComponent<EndScript> ();
			if (targetBoss != null) { // if the target is the target that i was loooking for 
				targetBoss.BossTakeDamage(damage); // since TakeDamage is public, we could use it off of this file
			}

			Target1 target = hit.transform.GetComponent<Target1> ();
			if (target != null) { // if the target is the target that i was loooking for 
				target.TakeDamage(damage); // since TakeDamage is public, we could use it off of this file
			}

			if (hit.rigidbody != null) {
				hit.rigidbody.AddForce (-hit.normal * impactForce);
			}

			GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy (impactGO, 2f);
		}
	}
}


// were gonna be using ray casting fror shooting