using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen : MonoBehaviour {

	// Use this for initialization
	public void LoadToScene (int sceneToLoad) {
		Application.LoadLevel(sceneToLoad);
	}
	

}
