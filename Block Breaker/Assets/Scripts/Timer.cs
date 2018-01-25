using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour {

	//private float countingTime;
	public Paddle paddle;
	//public string mainMenu;
	//private LifeSystem lfs;
	//public GameObject gameOverScreen;

	public float startingTime;

	private Text theText;

	//private PauseMenu thePauseMenu;


	// Use this for initialization
	void Start () {
	//	lfs = FindObjectOfType<LifeSystem> ();

		theText = GetComponent<Text> ();

		paddle = FindObjectOfType<Paddle> ();
		//thePauseMenu = FindObjectOfType<PauseMenu> ();
	}
	
	// Update is called once per frame
	void Update () {
		startingTime -= Time.deltaTime; //slowly decreases the time
		theText.text = "" + Mathf.Round(startingTime);

		//if (thePauseMenu.isPaused)
		//	return;

		if (startingTime <= 0) {
		//	gameOverScreen.SetActive (true);
		//	paddle.gameObject.SetActive (false);
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			SceneManager.LoadScene(4);
				Debug.Log ("Game Over");

			}
		}
	
	
	}
	/*public void ResetTime()
	/*{
		countingTime = startingTime;
	}*/
