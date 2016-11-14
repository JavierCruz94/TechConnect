using UnityEngine;
using System.Collections;

public class PanelReacciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	// Use this for initialization
	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<EligeReacciones> ().contResp = 0;
	}
}
