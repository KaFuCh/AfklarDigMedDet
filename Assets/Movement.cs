using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public KeyCode moveRight = new KeyCode();
	public KeyCode moveLeft = new KeyCode();
	public KeyCode jump = new KeyCode();
	public float velocity = 5;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(moveRight))
		{
			Vector2 newVel = rigidbody2D.velocity;
			newVel.x = velocity;
			rigidbody2D.velocity = newVel;
		}
		else if (Input.GetKey(moveLeft))
		{
			Vector2 newVel = rigidbody2D.velocity;
			newVel.x = velocity *-1;
			rigidbody2D.velocity = newVel;
		}
		else if (Input.GetKey(jump))
		{
			Vector2 newVel = rigidbody2D.velocity;
			newVel.y = velocity;
			rigidbody2D.velocity = newVel;
		}
		else 
		{
			Vector2 newVel = rigidbody2D.velocity;
			newVel.x = 0;
			rigidbody2D.velocity = newVel;
		}
	}
}