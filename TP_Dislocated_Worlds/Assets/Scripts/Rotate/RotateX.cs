using UnityEngine;
using System.Collections;

public class RotateX : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Rotation de 5 degrés autour de l'axe des Y
		transform.Rotate (1, 0, 0);
	}
}
