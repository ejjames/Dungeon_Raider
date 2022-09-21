using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toLevelOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col) 
    {

            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
			
        
}
}
