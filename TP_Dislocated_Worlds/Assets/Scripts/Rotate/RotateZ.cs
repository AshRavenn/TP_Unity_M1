using UnityEngine;
using System.Collections;

public class RotateZ : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Rotation de 5 degrés autour de l'axe des Y
		transform.Rotate (0, 0, 1);
	}
}
