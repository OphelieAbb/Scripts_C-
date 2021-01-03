using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Girl : MonoBehaviour
{

    public float jumpSpeed;
    public float gravity;

    private Vector3 mouvement;
    private CharacterController controller;

   

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        controller.Move(mouvement * Time.deltaTime);
        mouvement.y -= gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            mouvement.y = 2f;

        }

    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
             
              
    }


}
    
