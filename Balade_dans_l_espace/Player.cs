using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float VitesseDeplacement = 5f;
	public float VitesseRotation = 5f;


    // Start is called before the first frame update
    void Start()
    {
     if (VitesseDeplacement < 10f)
	 {
	 	 Debug.Log ("coucou");
	 }

	 if (VitesseDeplacement < 10f)
	 {
	 	 Debug.Log ("aurevoir");
	 }

	 if (VitesseDeplacement < 10f)
	 {
	 	 Debug.Log ("tourneR");
	 }

	 if (VitesseDeplacement < 10f)
	 {
	 	 Debug.Log ("tourneL");
	 }

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.UpArrow))
	  {
	  	  transform.Translate(Vector3.forward *5* Time.deltaTime);
	  }

	     if (Input.GetKey(KeyCode.DownArrow))
	  {
	  	  transform.Translate(Vector3.back *5* Time.deltaTime);
	  }

	    if (Input.GetKey(KeyCode.RightArrow))
	  {
	  	  transform.Rotate(Vector3.up *10* Time.deltaTime);
	  }

		  if (Input.GetKey(KeyCode.LeftArrow))
	  {
	  	  transform.Rotate(Vector3.down *10* Time.deltaTime);
	  }
    }
}
