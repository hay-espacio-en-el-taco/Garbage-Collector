using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour {
	public BoxCollider2D collArriba, collAbajo, collDerecha, collIzquierda;
	public Camera cam;
	// Use this for initialization
	void Start () {
		collArriba.size = new Vector2 (cam.ScreenToWorldPoint(new Vector3(Screen.width * 1.5f,0f,0f)).x, 0.5f);
		collArriba.offset = new Vector2 (2f, cam.ScreenToWorldPoint (new Vector3 (2f, Screen.height, 0f)).y/2);

		collAbajo.size = new Vector2 (cam.ScreenToWorldPoint(new Vector3(Screen.width * 1.5f,0f,0f)).x, 0.5f);
		collAbajo.offset = new Vector2 (2f, cam.ScreenToWorldPoint (new Vector3 (2f, - Screen.height, 0f)).y/2);

		collIzquierda.size = new Vector2 (1f, cam.ScreenToWorldPoint(new Vector3(0f,Screen.width * 2f,0f)).y);
		collIzquierda.offset = new Vector2 (cam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x + 0.5f, -0.5f);

		collDerecha.size = new Vector2 (1f, cam.ScreenToWorldPoint(new Vector3(0f,Screen.width * 2f, 0f)).y);
		collDerecha.offset = new Vector2 (cam.ScreenToWorldPoint (new Vector3 (Screen.height, 0f, 0f)).x - 2f, -0.5f);
		Debug.Log (Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
