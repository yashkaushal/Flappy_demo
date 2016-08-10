using UnityEngine;
using System.Collections;

public class pipes : MonoBehaviour {

	public Vector3 velocity = new Vector3(-4, 0,0);
	
	// Use this for initialization
	void Start()
	{
		int range = 4;
		this.GetComponent<Rigidbody>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
			this.GetComponent<Rigidbody>().velocity = velocity;

	}
}
