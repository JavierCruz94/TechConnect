using UnityEngine;
using System.Collections;

public class PanelTFAplicaciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;


	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<TrueFalseAplicaciones> ().contResp = 0;
	}
}
