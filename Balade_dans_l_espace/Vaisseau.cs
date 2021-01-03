using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaisseau : MonoBehaviour
{

public Transform planete1;
public Transform planete2;
public float vitesse;

public float distanceMin = 2f;
private bool surPlanete1 = false;
private bool surPlanete2 = true;
private float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, planete1.position, Vitesse* Time.deltaTime);

		if(surPlanete1 == true)
		{
			transform.position = Vector3.MoveTowards (transform.position, planete2.position, vitesse* Time.deltaTime);

			transform.LookAt(planete2.position);

			distance = Vector3.Distance(transform.position, planete2.position);

			if (distance<distanceMin){
			
			surPlanete1 = false;
			surPlanete2 = true;

			}

		}
		if(surPlanete2 == true)
		{
			transform.position = Vector3.MoveTowards (transform.position, planete1.position, vitesse* Time.deltaTime);

			transform.LookAt(planete1.position);

		    distance = Vector3.Distance(planete1.position, transform.position);


			if (distance<distanceMin){
			
			surPlanete1 = true;
			surPlanete2 = false;

			}
		}
    }
	
	
}
