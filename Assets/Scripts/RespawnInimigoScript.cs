using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnInimigoScript : MonoBehaviour {

	public GameObject gbEnemy;
	float tempo;

	// Use this for initialization
	void Start () {
		tempo = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - tempo > 3.0f) {
			this.Respawn();
			tempo = Time.time;
		}
	}

	void Respawn () {
		GameObject go = Instantiate(gbEnemy) as GameObject;
		//go.transform.position = new Vector3 (Random.Range(-3.0f, 3.0f), 0.5f, Random.Range (-3.0f, 3.0f));
		go.transform.position = new Vector3 (Random.Range(-50.0f, 50.0f), 3.0f, 200.0f);
	}
}
