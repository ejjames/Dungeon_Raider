using UnityEngine;
public class bulletShooter : MonoBehaviour {
    public GameObject sphereSmall;
	public GameObject Cube;
    public float distanceFromPlayer = 1.53f;
    public float heightOfSpawn = 8.2f;
	public int counter = 0;
	public static int check; 
    void Start () {
		//col = Cube.GetComponent<MeshCollider>();
		check = 1;
	}
	
	void Update () {
        Vector3 spawningTheSphere;
        
		spawningTheSphere.z = 1.53f;
		spawningTheSphere.y = 8.2f;
		
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
			
			if (check == 1)
			{	
			check = 0;
			spawningTheSphere.x = Random.Range(-5.0f, 5.0f);
            Instantiate(sphereSmall, spawningTheSphere, Quaternion.identity);
			counter++;
			check = 1;
			

        }
			
		}

    }
	
	 //Vector3 GetRandomPoint()
    //{
        //int xRandom = 0;
        //int zRandom = 0;
        
        
        //xRandom = (int)Random.Range(col.bounds.min.x, col.bounds.max.x);
        //zRandom = (int)Random.Range(col.bounds.min.z, col.bounds.max.z);

        //return new Vector3(xRandom, 0.0f, zRandom);
//}
}