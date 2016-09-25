using UnityEngine;
using System.Collections;


public class Render : MonoBehaviour {
	
	public Color colorStart = Color.blue;

	public Renderer rend;
	void Start() {
		rend = GetComponent<Renderer>();
	}
}