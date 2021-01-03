using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
private Vector3 pos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        pos.x = Random.Range (-90f,90f);
		pos.y = Random.Range (-90f,90f);
		pos.z = Random.Range (-90f,90f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pos* Time.deltaTime);
    }
}