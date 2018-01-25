using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public string startLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
		public void StartGame()
	{
		SceneManager.LoadScene(startLevel);
		PlayerPrefs.SetInt ("CurrentPlayerScore", 0);
	}
	
}
