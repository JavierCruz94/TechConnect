using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EligeNomenclatura : MonoBehaviour {
	public Text[] arrResp = new Text[5];
	public GameObject panel;
	public Sprite[] spriteVidas = new Sprite[4];
	public GameObject vidas;
	public GameObject panelPerdiste;
	public GameObject panelGanaste;

	int contVidas;
	int contCorrectas;
	public int contResp = 0;
	private int slotBuena;
	private int pregunta;
	private int seleccion;

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
		for (int i = 1; i < arrResp.Length; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState) {
				contResp++;
				seleccion = i - 1;
			}
		}
	
		if (contResp == 1) {
			if (resp [seleccion, 1] == "si") {
				contCorrectas++;
				if (contCorrectas == 20) {
					//MasterNomenclatura.nivelDos = true;
					panelGanaste.SetActive (true);
				}
			} else {
				contVidas--;
			}
			Reinicia();
		} else {
			//pierde todas las vidas
			panel.SetActive (true);
		}
	}

	void Reinicia(){
		contResp = 0;
		for (int i = 1; i < arrResp.Length; i++) {
			arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState = false;
			arrResp [i].GetComponent<SeleccionaRespuesta> ().CambiaColor ();
		}
		for (int i = 0; i < 4; i++) {
			resp [i, 0] = "";
			resp [i, 1] = "";
		}
		if (contVidas < 0) {
			for (int i = 0; i < 49; i++) {
				BancoPreguntas.buenasNomeclatura [0, i, 2] = "no";
			}
			panelPerdiste.SetActive (true);
		} else 
			IniciaJuego ();
	}

	void IniciaJuego(){
		vidas.GetComponent<SpriteRenderer> ().sprite = spriteVidas [contVidas];
		slotBuena = (int)Random.Range (0.0f, 3.0f);
		pregunta = (int)Random.Range (0.0f, 49.0f);

		while (BancoPreguntas.buenasNomeclatura [0, pregunta, 2] == "si") {
			pregunta = (int)Random.Range (0.0f, 49.0f);
		}
		BancoPreguntas.buenasNomeclatura [0, pregunta, 2] = "si";
		//Escribir la pregunta en el título
		arrResp[0].GetComponent<Text>().text = BancoPreguntas.buenasNomeclatura[0,pregunta, 0];
		resp [slotBuena, 0] = BancoPreguntas.buenasNomeclatura [0,pregunta,1];
		resp [slotBuena, 1] = "si";

		//Asignar las respuestas erroneas en los espacios desocupados
		AsignarPreguntas(resp, BancoPreguntas.malasNomenclatura[0,pregunta,0]);
		AsignarPreguntas(resp, BancoPreguntas.malasNomenclatura[0,pregunta,1]);
		AsignarPreguntas(resp, BancoPreguntas.malasNomenclatura[0,pregunta,2]);

		//Cambiar el texto de las preguntas
		for (int i = 1; i < arrResp.Length; i++) {
			arrResp [i].GetComponent<Text> ().text = resp [i - 1, 0];
		}
	}
}
