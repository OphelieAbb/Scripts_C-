using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour
{
	public float speed;
    public Transform raquette;
    public Transform balle;
    public float distance;
    public float distanceMin = 2f;
    
    public float force = 10f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
		speed = Mathf.Clamp(speed, 0f, 50f);

		//float h = Input.GetAxis("Horizontal");

        float h = Input.GetAxis("Mouse X");

        transform.Translate ( Vector3.right * h * speed * Time.deltaTime);

		Vector3 positionTemporaire = transform.position;

		positionTemporaire.x = Mathf.Clamp(positionTemporaire.x, -32f, 32f);

		transform.position = positionTemporaire;

        
	}
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Raquette")
        {
            distance = Vector3.Distance(raquette.position, balle.position);

            if (distance > distanceMin)
            {

                Vector3 motion;
                motion.x = Random.Range(-1f, 1f);
                motion.y = 1;
                motion.z = 0;
                GetComponent<Rigidbody>().AddForce(motion * force);

            }
        }
      
    }
}
