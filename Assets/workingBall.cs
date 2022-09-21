using UnityEngine;
using System.Collections;


public class workingBall : MonoBehaviour {
	
	public GameObject sphereSmall;
	public GameObject BulletPrefab;
	private float reloadTimer;

	public GameObject ViewCamera = null;
	public AudioClip JumpSound = null;
	public AudioClip HitSound = null;
	public AudioClip CoinSound = null;

	private Rigidbody mRigidBody = null;
	private AudioSource mAudioSource = null;
	private bool mFloorTouched = false;
	private bool canShoot = true;

	void Start () {
		mRigidBody = GetComponent<Rigidbody> ();
		mAudioSource = GetComponent<AudioSource> ();
	}
	
	void FixedUpdate () {
		
		 if (Input.GetKeyDown("space"))
        {
            if(canShoot){
			canShoot = false;

			GameObject Temp = GameObject.Instantiate(BulletPrefab, this.transform.position + this.transform.forward, Quaternion.identity);
			Temp.GetComponent<Rigidbody>().velocity = this.transform.forward;
			
		}
        }
		canShoot= true;
		
		reloadTimer -= Time.deltaTime;
		
		Vector3 spawningTheSphere;
		spawningTheSphere.x = 1.53f;
		spawningTheSphere.z = 1.53f;
		spawningTheSphere.y = 8.2f;
		
		if (mRigidBody != null) {
			if (Input.GetButton ("Horizontal")) {
				mRigidBody.AddTorque(Vector3.back * Input.GetAxis("Horizontal")*10);
			}
			if (Input.GetButton ("Vertical")) {
				mRigidBody.AddTorque(Vector3.right * Input.GetAxis("Vertical")*10);
			}
			if (Input.GetButtonDown("Jump")) {
				if(mAudioSource != null && JumpSound != null){
										
					
				}
				
			}
		}
		if (ViewCamera != null) {
			Vector3 direction = (Vector3.up*2+Vector3.back)*2;
			RaycastHit hit;
			Debug.DrawLine(transform.position,transform.position+direction,Color.red);
			if(Physics.Linecast(transform.position,transform.position+direction,out hit)){
				ViewCamera.transform.position = hit.point;
			}else{
				ViewCamera.transform.position = transform.position+direction;
			}
			ViewCamera.transform.LookAt(transform.position);
		}
		
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = true;
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.y > .5f) {
				
			}
		} else {
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.magnitude > 2f) {
				
			}
		}
	}

	void OnCollisionExit(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = false;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("Coin")) {
			if(mAudioSource != null && CoinSound != null){
				
			}
			Destroy(other.gameObject);
		}
	}
}
