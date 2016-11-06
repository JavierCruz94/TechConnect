using UnityEngine;
using System.Collections;

public class PanelPreguntas1 : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<EligeNomenclatura> ().contResp = 0;
	}
}
