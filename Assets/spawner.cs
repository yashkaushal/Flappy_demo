using UnityEngine;

public class spawner : MonoBehaviour {


	public GameObject pipes;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("Makepipes", 1f, 1.5f);
	}
	
	void Makepipes()
	{
		Instantiate(pipes,new Vector3(10,0,0),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
