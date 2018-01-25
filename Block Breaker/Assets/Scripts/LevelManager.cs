using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	private Paddle paddle;
	public BallScript bs;

	// Use this for initialization
	void Start () {
		paddle = FindObjectOfType<Paddle> ();
		bs = FindObjectOfType<BallScript> ();
	}
	
	// Update is called once per frame
	void Update () {

		bs.isDead = false;

	}
	public void RespawnPlayer()
	{
		Debug.Log ("Paddle respawn");

		paddle.transform.position = currentCheckpoint.transform.position;
		bs.transform.position =currentCheckpoint.transform.position / 2 ;




		//bs.Live ();

	}
}
