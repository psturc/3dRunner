using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce;
	public float sidewaysForce;
	public float jumpForce;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d")) 
		{
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}

		if (Input.GetKey("a")) 
		{
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce (0, jumpForce * Time.deltaTime, 0);	
		}

		if (rb.position.y < -1f) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
