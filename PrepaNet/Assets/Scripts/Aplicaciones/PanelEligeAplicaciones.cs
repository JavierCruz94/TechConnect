using UnityEngine;
using System.Collections;

public class PanelEligeAplicaciones : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<EligeAplicaciones> ().contResp = 0;
	}
}
