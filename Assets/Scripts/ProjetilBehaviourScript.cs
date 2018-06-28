using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilBehaviourScript : MonoBehaviour {

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
			GameObject goT = Instantiate(projetilPrefab) as GameObject;
			go.transform.position = this.gameObject.transform.position;
			go.transform.rotation = this.gameObject.transform.rotation;
			go.transform.Translate (Vector3.forward * 1.0f);
			go.transform.Translate (Vector3.up * -10.0f);
			go.GetComponent<Rigidbody> ().AddForce (go.transform.right * forca);

			goT.transform.position = this.gameObject.transform.position;
			goT.transform.rotation = this.gameObject.transform.rotation;
			goT.transform.Translate (Vector3.forward * 1.0f);
			goT.transform.Translate (Vector3.up * 10.0f);
			goT.GetComponent<Rigidbody> ().AddForce (goT.transform.right * forca);
		}

	}
}
