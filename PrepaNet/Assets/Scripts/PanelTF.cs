using UnityEngine;
using System.Collections;

public class PanelTF : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<TrueFalseF> ().contResp = 0;
	}
}