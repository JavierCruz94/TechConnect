using UnityEngine;
using System.Collections;

public class PanelTFReacciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	// Use this for initialization
	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<TrueFalseReacciones> ().contResp = 0;
	}
}
