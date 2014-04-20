using UnityEngine;
using System.Collections;

public class SpawnMet : MonoBehaviour {

	public GameObject met;
	public float speed;

	public GameObject[] mets;

	public Vector2 ySpread = new Vector2(-2,2);

	// Use this for initialization
	void Awake () {

		StartCoroutine(spawn());
	
	}
	




	IEnumerator spawn(){


		yield return new WaitForSeconds(Random.Range(0.5f, 2));
		GameObject tmp = (GameObject) Instantiate(mets[Random.Range(0,mets.Length-1)],new Vector3(this.transform.position.x,this.transform.position.y + Random.Range(ySpread.x,ySpread.y),this.transform.position.z),Random.rotation);
		//tmp.rigidbody.AddExplosionForce(speed, this.transform.position + new Vector3(10,0,0),100);
		//tmp.rigidbody.AddForce(speed,0,0);
		//tmp.rigidbody.velocity = new Vector3(-speed,0,0);
		Vector3 dir = Universal.Planet.transform.position - tmp.transform.position; // calculated the direction...
		// and kick!
		tmp.transform.rigidbody.AddForce((Vector3.up * Random.Range(-2,2))+(dir.normalized * speed), ForceMode.Impulse);
		StartCoroutine(spawn());

	}
}
