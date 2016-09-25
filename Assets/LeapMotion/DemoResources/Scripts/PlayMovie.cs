using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour {


	public MovieTexture movieOne;
	public MovieTexture movieThree;
	public MovieTexture movieFour;
	// Use this for initialization

	/*void Start()
	{
		Debug.Log ("start");
		Renderer r = GetComponent<Renderer> ();
		MovieTexture movieOne = (MovieTexture).r.material.mainTexture ();
		movieOne.Play ();
	}
	// Update is called once per frame
	public void OnTriggerEnter(Collider other) {
		
		Debug.Log ("enter2");
		Renderer r = GetComponent<Renderer> ();
		MovieTexture movieThree = (MovieTexture).r.material.mainTexture ();
		movieThree = gameObject.GetComponent<MovieTexture>();
		movieThree.Play ();
	}
/*
	public void OnTriggerEnter3(Collider other) {
		Debug.Log ("enter3");
		movieFour = gameObject.GetComponent<MovieTexture>();
		movieFour.Play ();
	}
*/

}
	