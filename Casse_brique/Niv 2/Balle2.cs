using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balle2 : MonoBehaviour

{

    public Vector3 deplacement = new Vector3(10, 10, 0);
    public int nbrBrique = 9;
    public GameObject prefabDebris;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(deplacement * Time.deltaTime);
        GetComponent<Rigidbody>().velocity = deplacement;
        speed = Mathf.Clamp(speed, 0f, 5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal);

        if (collision.gameObject.tag == "Brique")
        {
            Destroy(collision.gameObject);

            Instantiate(prefabDebris, transform.position, Quaternion.identity);

            nbrBrique--;
        }

        if (nbrBrique <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

