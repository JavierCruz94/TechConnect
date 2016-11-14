using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NombraCadena : MonoBehaviour {

	public Text[] arrResp = new Text[4];
	public Sprite[] arrImagen = new Sprite[5];
	public Sprite[] arrVidas = new Sprite[4];
	public GameObject vidas;
	public GameObject imagen;
	public GameObject panel;
	public GameObject panelGanaste;
	public GameObject panelPerdiste;

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
		slotBuena = (int)Random.Range (0.0f, 3.0f);
		pregunta = (int)Random.Range (0.0f, 19.0f);

		while (BancoPreguntas.cadenaNomenclatura [pregunta, 1] == "si") {
			pregunta = (int)Random.Range (0.0f, 19.0f);
		}

		BancoPreguntas.cadenaNomenclatura [pregunta, 1] = "si";
		resp [slotBuena, 0] = BancoPreguntas.cadenaNomenclatura [pregunta, 0];
		resp [slotBuena, 1] = "si";
		imagen.GetComponent<SpriteRenderer> ().sprite = arrImagen [pregunta];

		int mala1 = (int)Random.Range (0.0f, 19.0f);
		while (mala1 == pregunta) {
			mala1 = (int)Random.Range (0.0f, 19.0f);
		}

		int mala2 = (int)Random.Range (0.0f, 19.0f);
		while (mala2 == pregunta || mala2 == mala1) {
			mala2 = (int)Random.Range (0.0f, 19.0f);
		}

		int mala3 = (int)Random.Range (0.0f, 19.0f);
		while (mala3 == pregunta || mala3 == mala2 || mala3 == mala1) {
			mala3 = (int)Random.Range (0.0f, 19.0f);
		}

		//Asignar las respuestas erroneas en los espacios desocupados
		AsignarPreguntas(resp, BancoPreguntas.cadenaNomenclatura[mala1, 0]);
		AsignarPreguntas(resp, BancoPreguntas.cadenaNomenclatura[mala2, 0]);
		AsignarPreguntas(resp, BancoPreguntas.cadenaNomenclatura[mala3, 0]);

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
				print ("bien");
				if (contCorrectas == 10) {
					//MasterNomenclatura.nivelDos = true;
					panelGanaste.SetActive (true);
				}
			} else {
				print ("mal");
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
				BancoPreguntas.cadenaNomenclatura [i, 2] = "no";
			}
			panelPerdiste.SetActive (true);
		} else 
			IniciaJuego ();
	}
}
