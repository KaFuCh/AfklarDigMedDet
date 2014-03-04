using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public KeyCode moveRightKey = new KeyCode();
	public KeyCode moveLeftKey = new KeyCode();
	public KeyCode jumpKey = new KeyCode();
	public float velocity = 5;
	Vector2 newVel = new Vector2();	

	// Update is called once per frame
	//void jump()

	void Update () 
	{

		if (Input.GetKey (moveRightKey)) 
		{
			newVel.y = rigidbody2D.velocity.y;
			newVel.x = velocity;
			rigidbody2D.velocity = newVel;
		} 
		else if (Input.GetKey (moveLeftKey)) 
		{
			newVel.y = rigidbody2D.velocity.y;
			newVel.x = -velocity;
			rigidbody2D.velocity = newVel;
		} 
		else
			newVel.x = 0;
		if (Input.GetKey (jumpKey)) 
		{
			newVel.y = velocity;
			rigidbody2D.velocity = newVel;
		} 

	}
}