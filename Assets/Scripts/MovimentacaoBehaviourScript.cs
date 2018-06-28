using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoBehaviourScript : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;	
	public bool camSwitch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.gameObject.transform.Rotate (Vector3.up * -0.8f);
		} else if(Input.GetKey (KeyCode.DownArrow)) {
			this.gameObject.transform.Rotate (Vector3.up * 0.8f);
		}else if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (Vector3.up * 1f);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate( Vector3.up * -1f);
		}

		if (Input.GetKeyDown (KeyCode.C) ){
			camSwitch = !camSwitch;
			///cam1.enabled = !cam1.enabled;
			cam1.gameObject.SetActive (camSwitch);
			//cam2.enabled = !cam2.enabled;
			cam2.gameObject.SetActive (!camSwitch);
		}
	}
}
