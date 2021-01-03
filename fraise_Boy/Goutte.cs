using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goutte : MonoBehaviour
{
	public Vector3 velocity;
	public float force;

	// Start is called before the first frame update
	void Start()
    {
		GetComponent<Rigidbody>().AddForce(velocity * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnCollisionEnter()
	{
		Destroy(GetComponent<Rigidbody>());
		Destroy(this);
	}
}
