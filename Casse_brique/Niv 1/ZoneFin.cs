using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneFin : MonoBehaviour
{
	// Start is called before the first frame update
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Balle")
		{

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
