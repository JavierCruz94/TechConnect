using UnityEngine;
using System.Collections;

public class Salir : MonoBehaviour {

	public GameObject panel;

	public void MostrarPanel() {
		panel.SetActive(true);
	}

	public void QuitarPanel() {
		panel.SetActive (false);
	}

	public void SalirAplicacion() {
		Application.Quit ();
	}
}
