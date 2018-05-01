using UnityEngine;

public class EndScript : MonoBehaviour {
	public GameManager gameManager;

	public float health = 50f;

	public void BossTakeDamage (float amount) {
		health -= amount;
		if (health <= 0f) {
			Debug.Log ("TELL ME !!!!");
			gameManager.CompleteLevel ();
		} 
	}


	void Die() {
		Destroy (gameObject);
	}
}
