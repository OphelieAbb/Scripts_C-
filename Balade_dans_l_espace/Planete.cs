using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planete : MonoBehaviour
{
	public float VitesseRotation = 50f;
	public float VitesseTournerAutour = 50f;
	public Transform Centre;

    // Start is called before the first frame update
    void Start()
	{
	
	}

    // Update is called once per frame
    void Update()
    {
	  	  transform.Rotate(Vector3.up *VitesseRotation* Time.deltaTime);
		  transform.RotateAround(Centre.position, Vector3.up, VitesseTournerAutour * Time.deltaTime);
    }


}
