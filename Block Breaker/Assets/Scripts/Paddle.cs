using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public Rigidbody2D rb2d;
	public float speed;
	public float maxX;
	//bool firstColision = false;



	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxisRaw ("Horizontal") * speed;

		if (x < 0) {
			MoveLeft ();
		}
		if (x > 0) {
			MoveRight ();
		}

		if (x == 0) {
			Stop ();
		}

		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp (pos.x,-maxX,maxX);	// to limit our paddle position
		transform.position = pos;
	}

	void MoveLeft()
	{
		rb2d.velocity = new Vector2 (-speed,0);
	}

	void MoveRight()
	{
		rb2d.velocity = new Vector2 (speed,0);
	}

	void Stop()
	{
		rb2d.velocity = Vector2.zero; // velocity = 0
	}

	/*void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Ball") 
		{
			firstColision = true;
			Vector3 tempVect = new Vector3(col.rigidbody.velocity.x * -1, col.rigidbody.velocity.y * -1, col.rigidbody.velocity.z);
			col.rigidbody.velocity = tempVect;
			speed++;

		}


	}*/


	/*public void BallHitPaddle()
	{
		GameObject paddle = GameObject.Find("Paddle");
		Vector2 paddlePosition = paddle.transform.position;
		Vector2 ballPosition = gameObject.transform.position;

		// this is the vector 'pointing' from the paddle to the ball
		Vector2 delta = ballPosition - paddlePosition;
		// normalizing converts a vector into a unit vector
		// (i.e. a vector with the same direction, but a magnitude of 1)
		Vector2 direction = delta.normalized;
		// set the velocity to be the direction vector scaled to the desired speed
		rb2d.velocity = direction * speed;    
}*/
}