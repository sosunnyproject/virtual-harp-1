 using UnityEngine;
using System.Collections;

public class SoundEffect: MonoBehaviour {

	public AudioSource source;
	bool colourChangeCollision = false;

	public void Awake()
		{
		source = GetComponent<AudioSource> ();

		}

	public void OnTriggerEnter (Collider other)
	{
		//if (!source.isPlaying){
		source.Play ();
		//}
		//else 
		colourChangeCollision = true;
	}
	public void checkColourChange()
	{
		if(colourChangeCollision)
		{
			transform.GetComponent<Renderer>().material.color = Color.yellow;
			if(!source.isPlaying) //Time.time > currentDelay
			{
				transform.GetComponent<Renderer>().material.color = Color.grey;
				colourChangeCollision = false;
			}
		}
	}

	public void Update()
	{
		checkColourChange();
	}
}
