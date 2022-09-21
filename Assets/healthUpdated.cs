using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class healthUpdated : MonoBehaviour
{
	
	public static int healthCount; 
	 void Start ()
    {
		healthCount = 0;
    }
	void Update () {
		if (healthCount == 3)
		{
			SceneManager.LoadScene(5);
		}
		
	}
	
}