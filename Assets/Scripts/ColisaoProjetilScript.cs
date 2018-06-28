using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColisaoProjetilScript : MonoBehaviour {

	float tempo;
	public Text pontuacao;
	private int pontos;

	// Use this for initialization
	void Start () {
		tempo = Time.time;
		pontos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pontuacao.text = "Pontos: " + pontos;

		if (Time.time - tempo > 5.0f) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter(Collision col){
		Debug.Log("Colisao");
		if (col.gameObject.tag.Equals("inimigo")){
			//col.gameObject.transform.position = new Vector3 (Random.Range(-3.0f, 3.0f), 0.5f, Random.Range (-3.0f, 3.0f));
			Destroy (col.gameObject);
			pontos += 1;
			Destroy (this.gameObject);
		}
	}
}
