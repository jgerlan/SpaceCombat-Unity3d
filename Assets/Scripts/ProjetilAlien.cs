using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilAlien : MonoBehaviour {

	public GameObject projetilPrefab;
	public float forca;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		forca = -4000.0f;
		if (Input.GetKeyDown (KeyCode.Space)) {
			//atira
			GameObject go = Instantiate(projetilPrefab) as GameObject;
			go.transform.position = this.gameObject.transform.position;
			go.transform.rotation = this.gameObject.transform.rotation;
			go.transform.Translate (Vector3.forward * 1.0f);
			go.transform.Translate (Vector3.up * 1.0f);
			go.GetComponent<Rigidbody> ().AddForce (go.transform.right * forca);
		}

	}

}
