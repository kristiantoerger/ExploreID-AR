using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantiTampilObjek : MonoBehaviour {

	//[Tooltip("Untuk Fungsi Menyembunyikan objek")]
	public void SembunyikanObjek(GameObject o){
		if (o != null) {
			o.SetActive (false);
		}
	}
	//[Tooltip("Untuk Fungsi Memunculkan objek")]
	public void MunculkanObjek(GameObject o){
		if (o != null) {
			o.SetActive (true);
		}
	}

}
