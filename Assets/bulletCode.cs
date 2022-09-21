using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	
	void OnCollisionEnter(Collision col) 
    {
			if (col.gameObject.CompareTag ("Player")) 
			
	{
			Destroy(this.gameObject);
	}
			if (col.gameObject.CompareTag ("Enemy")) 
			
	{
			Destroy(gameObject);
	}
	
	
            
			
        
}

}
