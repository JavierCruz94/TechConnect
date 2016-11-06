using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MasterNomenclatura : MonoBehaviour {

	public static bool nivelDos = true;
	public static bool nivelTres = false;

	public GameObject panelNiv2;
	public GameObject panelNiv3;

	// Use this for initialization
	void Start () {
	
	}

	public void Nivel2() {
		if (nivelDos)
			SceneManager.LoadScene ("TrueFalseNomenclatura");
		else 
			panelNiv2.SetActive (true);
	}

	public void Nivel3() {
		if (nivelTres)
			SceneManager.LoadScene ("");
		else 
			panelNiv3.SetActive (true);
	}
	
}
