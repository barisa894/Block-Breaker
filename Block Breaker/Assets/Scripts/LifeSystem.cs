using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour {

	//public GameObject gameOverScreen;
	//public float waitAfterGameOver;
	//public int levels = 1;
	//public Text levelText;
	public string leveltoLoad;
	public BallScript bs;
	public Paddle paddle;
	public int Lives = 4;
	public int Cur_Bricks = 0;
	public Text LiveText;
	//private Timer theTime;
	private Text theText;


	// Use this for initialization
	void Start () {
		theText = GetComponent<Text> ();
		//paddle = FindObjectOfType<Paddle> ();
		//theTime = FindObjectOfType<Timer> ();
		//UpdateGUI ();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		bs.Life ();
		//theTime.ResetTime ();
	}



	public void UpdateGUI()
	{
		//levelText.text = ("Levels: " + levels.ToString ());  
		LiveText.text = ("Lives: " + Lives.ToString ());  
		if (Lives <= 0)
			SceneManager.LoadScene (6);
		//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

		if (Cur_Bricks <= 0) 
		{
			SceneManager.LoadScene (leveltoLoad);
			//levels++;
		 
		}
	
	}

	/*public void KillPlayer()
	{
		Lives = 0;

	}*/
}

/*gameOverScreen.SetActive(true); //gameover
paddle.gameObject.SetActive(false); // player doesn't move


if (gameOverScreen.activeSelf) 
{
	waitAfterGameOver -= Time.deltaTime;
}

if (waitAfterGameOver < 0) 
{*/