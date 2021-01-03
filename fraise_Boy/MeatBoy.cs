using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MeatBoy : MonoBehaviour
{
	public float speed;
	public float jumpSpeed;
	public float gravity;

	private Vector3 mouvement;
	private CharacterController controller;

	public int jumpsMax = 2;
	private int jumpsCount;

	public GameObject gouttePrefab;
	public float cptGoutte;
	public float delayGoutte;

    private Vector3 defaultPosition = new Vector3 (0, 0, 0);
    

	void Awake()
	{
		controller = GetComponent<CharacterController>();
	}
	// Start is called before the first frame update
	void Start()
    {
        Vector3 defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		mouvement.x = Input.GetAxisRaw("Horizontal")*speed;
		controller.Move(mouvement * Time.deltaTime);
		mouvement.y -= gravity *Time.deltaTime;
		

		if (controller.isGrounded)
		{
			mouvement.y = 0;
			jumpsCount = 0;
		}
		if (Input.GetButtonDown("Jump"))
		{
			

			if (jumpsCount < jumpsMax) 
			{
				mouvement.y = jumpSpeed;
				jumpsCount++;

			}
		}

		if (mouvement.x!= 0f)
		{
			cptGoutte-=Time.deltaTime;
		}
		if (cptGoutte < 0) 
		{
			GameObject goutte = Instantiate(gouttePrefab, transform.position , Quaternion.identity);
			goutte.GetComponent<Goutte>().velocity = new Vector3(mouvement.x, speed, 0f);
			cptGoutte = delayGoutte;
		}
    }

    public void Die()
    {
		controller.enabled = false;
		transform.position = defaultPosition;
		controller.enabled = true;
	}

}
