using UnityEngine;
using System.Collections;

public class collisionMet : MonoBehaviour {

	public GameObject exp;
	public GameObject[] partic;
	public GameObject[] meti;

	public bool enabled;

	public int Damage;

void OnCollisionEnter(Collision col){
		if(col.transform.tag == "Earth" && enabled){
			GameObject.Instantiate(exp,this.transform.position,Random.rotation);
			Universal.Oxygen -= Damage;
			Destroy(this.gameObject);
		}else if(col.transform.tag == "Rocket" && enabled){
			GameObject.Instantiate(exp,this.transform.position,Random.rotation);

			foreach(GameObject part in partic){
				 GameObject tmp = (GameObject) Instantiate(part,this.transform.position,Random.rotation);
				tmp.transform.rigidbody.AddForce(new Vector3(Random.Range(-1000,1000),Random.Range(1000,-1000),Random.Range(-1000,1000)));
				//part.transform.rigidbody.velocity = new Vector3(5,5,5);
				//tmp.rigidbody.AddForce(5,5,5,ForceMode.Impulse);
				//print (tmp.transform.rigidbody.velocity);
			}

			GameObject.Instantiate(meti[Random.Range(0,meti.Length)],this.transform.position,Quaternion.Euler(0,180,0));
			Destroy(col.gameObject);
			Destroy(this.gameObject);

		}

	}
}
