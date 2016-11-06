using UnityEngine;
using System.Collections;

public class PanelNomenclatura : MonoBehaviour {
	public GameObject panel;

	public void QuitarPanel() {
		panel.SetActive (false);
	}
}
