using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

	public GameObject Base;
	public GameObject Rocket;

	public float speed =10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit))
			{

				if(hit.transform.tag == "Cobalt" ||hit.transform.tag == "Iron" ||hit.transform.tag == "Magnesium" || hit.transform.tag =="Zinc"){
					switch (hit.transform.tag)
					{
						//mats go iron , zinc, magne, cobolt 
					case "Cobalt":
						Universal.materials[3] += 10;
						GameObject.Destroy(hit.transform.gameObject);
						break;
					case "Iron":
						Universal.materials[0] += 10;
						GameObject.Destroy(hit.transform.gameObject);
						break;
					case "Magnesium":
						Universal.materials[2] += 10;
						GameObject.Destroy(hit.transform.gameObject);
						break;
					case "Zinc":
						Universal.materials[1] += 10;
						GameObject.Destroy(hit.transform.gameObject);
						break;
					default:
						print ("dunno");
						break;
					}
				}else{

					if(hit.point.x >= Base.transform.position.x ){

				GameObject Rock = (GameObject) Instantiate(Rocket,Base.transform.position,Quaternion.identity);
				Rock.transform.LookAt(new Vector3(hit.point.x,hit.point.y,base.transform.position.z));
				//Rock.transform.rigidbody.velocity =  Vector3.forward;

				Vector3 dir = hit.point - Rock.transform.position; // calculated the direction...
				// and kick!
				Rock.transform.rigidbody.AddForce(dir.normalized * speed, ForceMode.Impulse);
				//Destroy(GameObject.Find(hit.collider.gameObject.name));
					}
				}
			}

		}
	
	}
}
