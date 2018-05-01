using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class damagePlayer : MonoBehaviour {
	public int playerHealth=30;
	int damage=10;

	public float restartDelay = 1f;

	public GameObject CompleteLevelUI; 

	public void CompleteLevel () {
		CompleteLevelUI.SetActive (true);

	}

	void Start(){
		print (playerHealth);
	}
//	GameOver
 
	void OnControllerColliderHit(ControllerColliderHit hit) {
		
			playerHealth -= damage;
		if (playerHealth == 0) {
			Invoke("gameOver", restartDelay);
	
		}
			print ("Touched" + playerHealth);

	}

	void gameOver() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		print ("Game over");

	}
}
