using UnityEngine;
using System.Collections;

public class PanelCadena : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<NombraCadena> ().contResp = 0;
	}
}
