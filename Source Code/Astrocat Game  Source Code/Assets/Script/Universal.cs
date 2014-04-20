using UnityEngine;
using System.Collections;

public class Universal : MonoBehaviour {

	static public GameObject Planet;
	static public float Oxygen =50;


	static public int[] materials = new int[4];

	// Use this for initialization
	void Start () {
		Planet = GameObject.FindGameObjectWithTag("Earth");
	}
	
	// Update is called once per frame
	void Update () {
		Physics.IgnoreLayerCollision(9,10,true);


		GameObject[] dist = GameObject.FindObjectsOfType<GameObject> ();

		foreach (GameObject check in dist) {
						if (Vector3.Distance (Vector3.zero, check.gameObject.transform.position) >= 100) {

								GameObject.Destroy (check.gameObject);
						}
				}
	
	}
}
