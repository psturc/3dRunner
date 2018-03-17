using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter (Collision collissionInfo) 
	{
		if (collissionInfo.collider.tag == "Obstacle") 
		{
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame();

		}
	}
}
