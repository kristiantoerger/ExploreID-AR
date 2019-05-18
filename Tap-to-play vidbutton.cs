using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoSentuh : MonoBehaviour {
	VideoPlayer vid;
	// Use this for initialization
	void Start () {
		vid = GetComponent<VideoPlayer> ();
	}


	 
	// Update is called once per frame
		void FixedUpdate () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit = new RaycastHit ();
		if (Input.GetMouseButtonDown (0)) { Debug.Log ("KOKGITU");
			if (Physics.Raycast (ray, out hit)) { //Debug.Log (hit.transform.name);
				vid = hit.transform.GetComponent<VideoPlayer> ();
				//Debug.Log (vid.clip+" play \n-----");
				vid.Play();
				if (vid.isPlaying) {
					vid.Pause ();
				} else {
					vid.Play ();
				}
			}
		}
	}
}
