using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {  
		transform.localPosition += transform.forward * 5 * Time.deltaTime; 
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.LogWarning ("HIT");
		//Destroy(col.gameObject);

	}

	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown (0)) {
			//Debug.LogWarning ("gameObject.name");
			Destroy(this.gameObject);
				}
	}
}
