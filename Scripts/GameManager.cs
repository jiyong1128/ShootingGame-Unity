using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public int playerHealth=30;
	int damage=10;

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject CompleteLevelUI; 

	public void CompleteLevel () {
		Debug.Log ("Complete Level");
		CompleteLevelUI.SetActive (true);

	}

	void OnControllerColliderHit(ControllerColliderHit hit) {

		playerHealth -= damage;
		if (playerHealth == 0) {
			Invoke("gameOver", restartDelay);

		}
		print ("Touched" + playerHealth);

	}

	public void EndGame() {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game Over");
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}