using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSound : MonoBehaviour {
	public AudioSource source;
	private AudioClip clip;
	public GameObject gun;
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			playShot();
		}
	}


			void playShot () {
				var gunAudio = gun.GetComponent<AudioSource> ();
				clip = gunAudio.clip;
				gunAudio.PlayOneShot(clip);
			}
}
