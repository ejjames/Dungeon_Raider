using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scoreUpdated : MonoBehaviour
{
	
	public static int scoreCount; 
	 void Start ()
    {
		scoreCount = 0;
    }
	void Update () {
		if (scoreCount == 10)
		{
			SceneManager.LoadScene(4);
		}
		
	}
	
}