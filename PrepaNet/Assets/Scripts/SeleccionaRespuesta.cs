using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SeleccionaRespuesta : MonoBehaviour{

	public bool clickState = false;

	public void changeState() {
		clickState = !clickState;

		CambiaColor();
	}

	public void CambiaColor() {
		if (clickState) {
			ChangeColor (1.0f, 0.0f, 1.0f, 1.0f);
		} else {
			ChangeColor (1.0f, 1.0f, 1.0f, 1.0f);
		}
	}

	public void ColorEncima() {
		ChangeColor (1.0f, 0.92f, 0.016f, 1.0f);
	}

	public void ColorSale() {
		if (clickState)
			ChangeColor (1.0f, 0.0f, 1.0f, 1.0f);
		else
			ChangeColor (1.0f, 1.0f, 1.0f, 1.0f);
	}

	public void ChangeColor(float a, float b, float c, float d) {
		Color color = new Color (a,b,c,d);

		this.gameObject.GetComponent<Text> ().color = color;
	}

		
}
