using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrueFalseF : MonoBehaviour {

	public Sprite[] arrImagen = new Sprite[2];
	public GameObject imagen;
	string[,] pregunta = new string[,]{{"",""}};
	public Text preg;
	public Text[] arrResp = new Text[2];
	public int contResp = 0;
	public GameObject panel;
	public int bancoPregunta = 0;
	// Use this for initialization
	void Start () {

		bancoPregunta = (int)Random.Range (0.0f, 2.0f);
		pregunta [0, 0] = BancoPreguntas.tOrf [bancoPregunta, 0];
		pregunta [0, 1] = BancoPreguntas.tOrf [bancoPregunta, 1];
		preg.GetComponent<Text> ().text = pregunta [0, 0];
		imagen.GetComponent<SpriteRenderer> ().sprite = arrImagen [bancoPregunta];


	}

	public void Validar() {
		int seleccion = 0;
		contResp = 0;
		for (int i = 0; i < arrResp.Length; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState) {
				contResp++;
				seleccion = i;
			}
		}

		if (contResp == 1) {
			//saber si fue true o false
			string trad = null;
			if (seleccion == 0) {
				trad = "si";
			} 
			else {
				trad = "no";
			}

			//validar todo
			if (BancoPreguntas.tOrf[bancoPregunta, 1] == trad) {
				print ("bien");
			} else {
				print ("mal");
			}
		} else {
			panel.SetActive (true);
		}
	}

}
