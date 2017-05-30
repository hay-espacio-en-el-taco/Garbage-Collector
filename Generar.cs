using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour {
	public BoxCollider2D collArriba, collAbajo, collDerecha, collIzquierda;
	public Camera cam;
	// Use this for initialization
	void Start () {
		collArriba.size = new Vector2 (cam.ScreenToWorldPoint(new Vector3(Screen.width * 2f,0f,0f)).x, 1f);
		collArriba.offset = new Vector2 (0f, cam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y -0.5f);

		collAbajo.size = new Vector2 (cam.ScreenToWorldPoint(new Vector3(Screen.width * 2f,0f,0f)).x, 1f);
		collAbajo.offset = new Vector2 (0f, cam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y + 0.7f);

		collIzquierda.size = new Vector2 (1f, cam.ScreenToWorldPoint(new Vector3(0f,Screen.width * 2f,0f)).y);
		collIzquierda.offset = new Vector2 (cam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.5f, 0f);

		collDerecha.size = new Vector2 (1f, cam.ScreenToWorldPoint(new Vector3(0f,Screen.width * 2f, 0f)).y);
		collDerecha.offset = new Vector2 (cam.ScreenToWorldPoint (new Vector3 (Screen.height, 0f, 0f)).x + 0.5f, 0f);
		Debug.Log (Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}
