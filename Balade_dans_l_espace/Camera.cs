using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	public Transform joueur;
	public float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ciblePos = joueur.position;
		ciblePos.y = transform.position.y;

		transform.position = Vector3.Lerp(transform.position, ciblePos, vitesse*Time.deltaTime);

    }
}
