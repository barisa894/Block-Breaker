using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class BallScript : MonoBehaviour {

	//public float min_y;
	public Paddle paddle;
	public Rigidbody2D rb2d;
	//Vector2 oldVel;
	//public float ballForce;
	bool gameStarted = false;
	public Transform ballChecker;
	//public string leveltoLoad;
	private LifeSystem lfs;
	public LevelManager lm;
	//public MainHud mh;
	public float speed;
	public bool isDead;

//	public float velocity = 1;
//	private Vector3 direction;

			
	
	// Use this for initialization
	void Start () {
		// Initial Velocity
		//GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
		lfs = GameObject.Find ("LifeSystem").GetComponent<LifeSystem> ();
		isDead = false;
		//rb2d = GetComponent<Rigidbody2D> ();
		//mh = GameObject.Find ("MainHud").GetComponent<MainHud> ();

		/*float randomDirection = UnityEngine.Random.Range (-1f, 1f);
		int x = (int)Mathf.Sign (randomDirection);
		direction = new Vector3 (x, 1, 0);
		direction.Normalize ();
*/
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Space) && gameStarted == false) {
			transform.SetParent (null); // redBall is not anymore a child
			rb2d.isKinematic = false;
			//oldVel = rb2d.velocity;
			//rb2d.AddForce (new Vector2 (ballForce, ballForce));
			//rb2d.velocity =rb2d.velocity.normalized;
			gameStarted = true;
			//GiveBoostIfMovingOnXorYAxis ();
		}

//		GetComponent<Transform> ().position += direction * velocity * Time.deltaTime;
	
/*	void OnCollisionEnter2D (Collision2D col)
	{
		direction = Vector3.Reflect (direction, col.contacts [0].normal);
		direction.Normalize ();
	}
*/
			/*if((rb2d.velocity.y < min_y_velocity) && 
				(Mathf.Sign(rb2d.velocity.y) == 1))
			{
				rb2d.AddForce(new Vector2(0, 5f));
			} 
			else if((rb2d.velocity.y > -min_y_velocity) && 
				(Mathf.Sign(rb2d.velocity.y) == -1))
			{
				rb2d.AddForce(new Vector2(0, -5f));
			}*/

		if(( rb2d.velocity.y < speed) && 
			(Mathf.Sign(rb2d.velocity.y) == 1))
		{
			rb2d.AddForce(new Vector2(0, 8f));
		} 
		else if((rb2d.velocity.y > -speed) && 
			(Mathf.Sign(rb2d.velocity.y) == -1))
		{
			rb2d.AddForce(new Vector2(0, -8f));
		}

		if((  rb2d.velocity.y > speed) && 
			(Mathf.Sign(rb2d.velocity.y) == 1))
		{
			rb2d.AddForce(new Vector2(0, -8f));
		} 
		else if((rb2d.velocity.y < -speed) && 
			(Mathf.Sign(rb2d.velocity.y) == -1))
		{
			rb2d.AddForce(new Vector2(0, 8f));
		}

		if((  rb2d.velocity.x < speed) && 
			(Mathf.Sign(rb2d.velocity.x) == 1))
		{
			rb2d.AddForce(new Vector2( 8f,0));
		} 
		else if((rb2d.velocity.x > -speed) && 
			(Mathf.Sign(rb2d.velocity.x) == -1))
		{
			rb2d.AddForce(new Vector2( -8f,0));
		}

		if((  rb2d.velocity.x > speed) && 
			(Mathf.Sign(rb2d.velocity.x) == 1))
		{
			rb2d.AddForce(new Vector2( -8f,0));
		} 
		else if((rb2d.velocity.x < -speed) && 
			(Mathf.Sign(rb2d.velocity.x) == -1))
		{
			rb2d.AddForce(new Vector2( 8f,0));
		}


		}
	/*void FixedUpdate()
	{
		rb2d.velocity = rb2d.velocity.normalized;
		rb2d.velocity.Scale(new Vector2(speed,speed));
	}*/
	public void Life(){
		if (transform.position.y < ballChecker.transform.position.y && !isDead) {

			lfs.Lives--;
			isDead = true;
			lm.RespawnPlayer ();
			lfs.UpdateGUI ();
			Debug.Log ("Life's taken");
		}
	}
}

	/*void OnCollisionEnter2D (Collision2D c) {
	ContactPoint2D cp = c.contacts[0];
	//calculate with addition of normal vector
		rb2d.velocity = oldVel + cp.normal*2.0f*oldVel.magnitude;

		// calculate with Vector3.Reflect
		rb2d.velocity = Vector3.Reflect(oldVel,cp.normal);

		// bumper effect to speed up ball
		rb2d.velocity += cp.normal*2.0f;
	}

*/
	/* float hitFactor(Vector2 ballPos, Vector2 paddlePos,
		float paddleWidth) {
		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket
		return (ballPos.x - paddlePos.x) / paddleWidth;
	}

/*	private void GiveBoostIfMovingOnXorYAxis()
	{
		if (Mathf.Abs (rb2d.velocity.x - 0.2f) <= 0.2f) {
			//left or right?
			bool right = Random.Range (-1.0f, 1.0f) >= 0;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (right ? 5.0f : -5.0f, 0), ForceMode2D.Impulse);
		}

		if(Mathf.Abs (rb2d.velocity.y - 0.2f) <= 0.2f)
		{
			bool down = Random.Range (-1.0f, 1.0f) >= 0;
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (down ? 5.0f : -5.0f, 0), ForceMode2D.Impulse);

			}
	}
}*/

	/*void OnCollisionEnter2D(Collision2D col)
		{
		if (col.gameObject.tag == "Paddle")
				{

			float x = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.x);

			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(x, 1).normalized ;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
		}
}
}

 

	//public void Ball ()
//	{
//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary && gameStarted == false) {
//			transform.SetParent (null); // redBall is not anymore a child
//		rb2d.isKinematic = false;

	

	//public void Live()
	//	{
	//		isDead = false;
	//	}
///*/