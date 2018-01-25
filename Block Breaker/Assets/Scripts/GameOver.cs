using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text points;
	private int points_count = 0;
	// Use this for initialization
	void Start () {
		points_count = MainHud.score;
	}
	
	// Update is called once per frame
	void Update () {
		
		points.text = points_count.ToString ();
	}
	public void PlayAgain()
	{
		SceneManager.LoadScene(0);
		MainHud.score = 0;
	}
}
