using UnityEngine;
using System.Collections;

public class PanelCadenaAplicaciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;


	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<CadenaAplicaciones> ().contResp = 0;
	}
}
