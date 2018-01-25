using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainHud : MonoBehaviour {

	public static int  score = 0;
	public Text scoreText;
	//public static int level = 0;
	//public Text levelText;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore()
	{
		//level++;
		score++;
		//levelText.text = "Level: " + level++;
		scoreText.text = "Score: " + score;
	}
	/*public void DecrementScore()
	{
		score--;
		scoreText.text  = "Score: " + score;
*/
}
