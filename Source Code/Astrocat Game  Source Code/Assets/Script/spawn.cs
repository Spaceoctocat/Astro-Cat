using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject[] Rocks;

	private GameObject per;

	public bool dest = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print(this.gameObject.transform.rigidbody.velocity);

		foreach(GameObject pos in GameObject.FindGameObjectsWithTag("spawn")){
			per = pos.transform.parent.gameObject;
			GameObject.Destroy(pos.gameObject);
		GameObject tmp = (GameObject) Instantiate(Rocks[Random.Range(0,Rocks.Length)],pos.transform.position, Random.rotation);
		//	tmp.transform.IsChildOf(this.transform);
			tmp.transform.parent = per.transform;
		}

		if(dest){

			for(int i =0; i<=this.transform.childCount -1; i++){
				GameObject tmp = (GameObject) this.transform.GetChild(i).gameObject;
				tmp.transform.collider.enabled = true;
				tmp.rigidbody.isKinematic = false;
				tmp.rigidbody.velocity = this.rigidbody.velocity;
				tmp.rigidbody.angularVelocity = this.transform.rigidbody.angularVelocity;
				tmp.rigidbody.AddExplosionForce(500, new Vector3(tmp.transform.localPosition.x,tmp.transform.localPosition.y,this.transform.localPosition.z),50);
				collisionMet tmps = tmp.gameObject.GetComponent<collisionMet>();
				tmps.enabled = true;

				GameObject.Destroy(this.gameObject);


			}
			this.gameObject.transform.DetachChildren();
		}
	}
}













