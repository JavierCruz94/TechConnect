using UnityEngine;
using System.Collections;

public class PanelCadenaReacciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	// Use this for initialization
	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<CadenaReacciones> ().contResp = 0;
	}
}
