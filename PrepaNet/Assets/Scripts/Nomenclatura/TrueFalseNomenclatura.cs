using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrueFalseNomenclatura : MonoBehaviour {
	
	public Sprite[] arrImagen = new Sprite[15];
	public GameObject imagen;
	public Text preg;
	public Text[] arrResp = new Text[2];
	public GameObject panel;
	public GameObject panelPerdiste;
	public GameObject panelGanaste;
	public GameObject vidas;
	public Sprite[] arrVidas = new Sprite[4];

	public int bancoPregunta = 0;
	string[,] pregunta = new string[,]{{"",""}};
	public int contResp;
	private int contVidas;
	int respCorrectas;

	// Use this for initialization
	void Start () {
		contVidas = 3;
		respCorrectas = 0;
		panelGanaste.SetActive (false);
		panelPerdiste.SetActive (false);
		InicioJuego ();
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
			if (BancoPreguntas.tOrfNomenclatura[0,bancoPregunta, 1] == trad) {
				//print ("bien");
				respCorrectas++;
				if (respCorrectas == 8) {
					MasterNomenclatura.nivelTres = true;
					panelGanaste.SetActive (true);
				}
			} else {
				//print ("mal");
				contVidas--;
			} 
			Reinicia ();
		} else {
			panel.SetActive (true);
		}
	}

	void InicioJuego() {
		bancoPregunta = (int)Random.Range (0.0f, 14.0f);
		vidas.GetComponent<SpriteRenderer> ().sprite = arrVidas [contVidas];

		while (BancoPreguntas.tOrfNomenclatura [0, bancoPregunta, 2] == "si") {
			bancoPregunta = (int)Random.Range (0.0f, 14.0f);
		}
		BancoPreguntas.tOrfNomenclatura [0, bancoPregunta, 2] = "si";

		pregunta [0, 0] = BancoPreguntas.tOrfNomenclatura [0,bancoPregunta, 0];
		pregunta [0, 1] = BancoPreguntas.tOrfNomenclatura [0,bancoPregunta, 1];
		preg.GetComponent<Text> ().text = pregunta [0, 0];
		imagen.GetComponent<SpriteRenderer> ().sprite = arrImagen [bancoPregunta];
	}

	void Reinicia() {
		contResp = 0;

		for (int i = 0; i < 2; i++) {
			arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState = false;
			arrResp [i].GetComponent<SeleccionaRespuesta> ().CambiaColor ();
		}

		pregunta [0, 0] = "";
		pregunta [0, 1] = "";

		if (contVidas < 0) {
			for (int i = 0; i < 2; i++) {
				BancoPreguntas.tOrfNomenclatura [0, i, 2] = "no";
			}
			panelPerdiste.SetActive (true);
		} else 
			InicioJuego ();
	}

}
