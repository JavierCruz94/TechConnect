﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CadenaAplicaciones : MonoBehaviour {

	public Text[] arrResp = new Text[4];
	public Sprite[] arrImagen = new Sprite[5];
	public Sprite[] arrVidas = new Sprite[4];
	public GameObject vidas;
	public GameObject imagen;
	public GameObject panel;
	public GameObject panelGanaste;
	public GameObject panelPerdiste;
	public GameObject buenas;

	int contVidas;
	int contCorrectas;
	public int contResp;
	int slotBuena;
	int pregunta;
	int seleccion;

	//Inicializar arreglo
	string[,] resp = new string[,] { 
		{ "", "" }, { "", "" }, { "", "" }, { "", "" }
	};

	// Use this for initialization
	void Start () {
		contVidas = 3;
		contCorrectas = 0;
		panelPerdiste.SetActive (false);
		panelGanaste.SetActive (false);
		IniciaJuego ();
	}


	void IniciaJuego(){
		vidas.GetComponent<SpriteRenderer> ().sprite = arrVidas [contVidas];
		buenas.GetComponent<Text> ().text = contCorrectas + " / 10";
		slotBuena = (int)Random.Range (0.0f, 3.0f);
		pregunta = (int)Random.Range (0.0f, 19.0f);

		while (BancoPreguntas.relacionaAplicaciones [pregunta, 1] == "si") {
			pregunta = (int)Random.Range (0.0f, 19.0f);
		}

		BancoPreguntas.relacionaAplicaciones [pregunta, 1] = "si";
		resp [slotBuena, 0] = BancoPreguntas.relacionaAplicaciones [pregunta, 0];
		resp [slotBuena, 1] = "si";
		imagen.GetComponent<SpriteRenderer> ().sprite = arrImagen [pregunta];
		int numMin = 0;
		int numMax = 0;

		if (pregunta < 7) {
			numMin = 0;
			numMax = 6;
		} else if (pregunta > 6 && pregunta < 13) {
			numMin = 7;
			numMax = 12;
		} else {
			numMin = 13;
			numMax = 19;
		}
		int mala1 = (int)Random.Range ((float)numMin, (float)numMax);
		while (mala1 == pregunta) {
			mala1 = (int)Random.Range ((float)numMin, (float)numMax);
		}

		int mala2 = (int)Random.Range ((float)numMin, (float)numMax);
		while (mala2 == pregunta || mala2 == mala1) {
			mala2 = (int)Random.Range ((float)numMin, (float)numMax);
		}

		int mala3 = (int)Random.Range ((float)numMin, (float)numMax);
		while (mala3 == pregunta || mala3 == mala2 || mala3 == mala1) {
			mala3 = (int)Random.Range ((float)numMin, (float)numMax);
		}

		//Asignar las respuestas erroneas en los espacios desocupados
		AsignarPreguntas(resp, BancoPreguntas.relacionaAplicaciones[mala1, 0]);
		AsignarPreguntas(resp, BancoPreguntas.relacionaAplicaciones[mala2, 0]);
		AsignarPreguntas(resp, BancoPreguntas.relacionaAplicaciones[mala3, 0]);

		//Cambiar el texto de las preguntas
		for (int i = 0; i < arrResp.Length; i++) {
			arrResp [i].GetComponent<Text> ().text = resp [i,0];
		}
	}

	void AsignarPreguntas (string[,] arreglo, string preg) {
		int i = 0;
		bool salir = false;
		while (i < 4 && !salir) {
			if (arreglo [i, 0] == "") {
				arreglo [i, 0] = preg;
				arreglo [i, 1] = "no";
				salir = true;
			}
			i++;
		}
	}

	public void Validar() {
		seleccion = 0;
		contResp = 0;
		for (int i = 0; i < arrResp.Length; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState) {
				contResp++;
				seleccion = i;
			}
		}

		if (contResp == 1) {
			if (resp [seleccion, 1] == "si") {
				contCorrectas++;
				if (contCorrectas == 10) {
					//MasterNomenclatura.nivelDos = true;
					panelGanaste.SetActive (true);
				}
			} else {
				contVidas--;
			}
			Reinicia();
		} else {
			panel.SetActive (true);
		}
	}

	void Reinicia(){
		contResp = 0;
		for (int i = 0; i < arrResp.Length; i++) {
			arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState = false;
			arrResp [i].GetComponent<SeleccionaRespuesta> ().CambiaColor ();
		}
		for (int i = 0; i < 4; i++) {
			resp [i, 0] = "";
			resp [i, 1] = "";
		}
		if (contVidas < 0) {
			for (int i = 0; i < 19; i++) {
				BancoPreguntas.relacionaAplicaciones [i, 1] = "no";
			}
 				panelPerdiste.SetActive (true);
		} else 
			IniciaJuego ();
	}
}
