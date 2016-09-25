using UnityEngine;
using System.Collections;

public class Videoplay : MonoBehaviour {

	public MovieTexture[] list;
	//public GameObject videoOne;
	//public GameObject videoTwo;
	//public GameObject videoThree;
	//public GameObject videoFour;

	void Start(){
			//Loading the items into the array
		list =  new MovieTexture[]{(MovieTexture)Resources.Load("Video/One")};
	}  /*
		void OnTriggerEnter (Collider other) { 

		Debug.Log ("Enter");
			//Renderer r = GetComponent<Renderer>();
			//MovieTexture movie = (MovieTexture)r.material.mainTexture;

			Resources.Load("Video/Two");
			}
		}*/
}