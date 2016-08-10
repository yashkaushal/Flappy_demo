using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector3 jumpForce = new Vector3(0, 300,0);
	bool died = false;
	
	// Update is called once per frame
	void Update ()
	{
		// Jump
		if(!died){
		if (Input.GetKeyUp("space"))
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			GetComponent<Rigidbody>().AddForce(jumpForce);
		}
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	void OnCollisionEnter(Collision other)
	{
		makedead();
	}
	void Die()
	{
		SceneManager.LoadScene(0);
	}
	void makedead(){
		died =true;
	}
}