using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisBrique2 : MonoBehaviour
{
    public float force = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 motion;
        motion.x = Random.Range(-1f, 1f);
        motion.y = 1;
        motion.z = 0;
        GetComponent<Rigidbody>().AddForce(motion * force);



    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

