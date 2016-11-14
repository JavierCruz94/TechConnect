using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class Play : MonoBehaviour {

	public MovieTexture movTexture;
	private AudioSource audio;

	void Start() {
		GetComponent<RawImage> ().texture = movTexture as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movTexture.audioClip;
		movTexture.Play();
		audio.Play ();
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && movTexture.isPlaying) {
			movTexture.Pause ();
		}
		else if (Input.GetKeyDown(KeyCode.Space) && !movTexture.isPlaying) {
			movTexture.Play ();
		}
	}
}
