using UnityEngine;
using System.Collections;

public class TouchControllers : MonoBehaviour {

	private PauseMenu thePauseMenu;

	//public BallScript bs;
	public GameObject player;
	// Use this for initialization
	void Start () {
		thePauseMenu = FindObjectOfType<PauseMenu> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//bs.Ball ();
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) {
			Vector2 touchPosition = Input.GetTouch (0).position;
			double halfScreen = Screen.width / 2.0;

			//check if it is left or right?
			if (touchPosition.x < halfScreen) {
				player.transform.Translate (Vector3.left * 5 * Time.deltaTime);
			} else if (touchPosition.x > halfScreen) {
				player.transform.Translate (Vector3.right * 5 * Time.deltaTime);
			}
		}
	}

	public void Pause()
	{
		//Debug.Log ("Paused");
		thePauseMenu.PauseUnpause ();

		//thePauseMenu.isPaused = !thePauseMenu.isPaused;
	}
}
			
