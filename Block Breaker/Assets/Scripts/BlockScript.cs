using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

	public MainHud mh;
	LifeSystem lfs;
	// Use this for initialization
	void Start () {

		mh = GameObject.FindWithTag ("MainHud").GetComponent<MainHud>();
		lfs = GameObject.Find ("LifeSystem").GetComponent<LifeSystem> ();
		lfs.Cur_Bricks++;
		//lfs.levels++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ball")
		{
			mh.IncrementScore ();
			Destroy (gameObject, 0.1f);
			lfs.Cur_Bricks--;
			lfs.UpdateGUI ();
		}
}
}
