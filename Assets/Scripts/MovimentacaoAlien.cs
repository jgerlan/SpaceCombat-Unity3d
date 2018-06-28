using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoAlien : MonoBehaviour {

	float tempo;
	float distance;
	public GameObject target;
	public GameObject projetilPrefab;
	public float forca;

	// Use this for initialization
	void Start () {
		tempo = Time.time;
	}

	// Update is called once per frame
	void Update () {
		distance = 40.0f;
		if (Time.time - tempo > 1.0f) {
			transform.position = transform.position - target.transform.forward * distance * Time.deltaTime;
		}

		if (Time.time - tempo > 10.0f) {
			Destroy (this.gameObject);
		}
	}
}
