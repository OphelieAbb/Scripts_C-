using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scie : MonoBehaviour
{
	
	public float speed;
    public GameObject gouttePrefab;
    public Texture tache;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player"){

			Instantiate(gouttePrefab, transform.position, Quaternion.identity);
            gameObject.GetComponent<Renderer>().material.mainTexture = tache;

            other.GetComponent<MeatBoy>().Die();
		}
    }
}
