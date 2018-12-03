using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("NextScene", 2f);
    }
	
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
