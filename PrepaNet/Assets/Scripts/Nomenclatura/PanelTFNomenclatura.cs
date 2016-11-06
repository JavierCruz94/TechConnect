using UnityEngine;
using System.Collections;

public class PanelTFNomenclatura : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;


	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<TrueFalseNomenclatura> ().contResp = 0;
		}

}
