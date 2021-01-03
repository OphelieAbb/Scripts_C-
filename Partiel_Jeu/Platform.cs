using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    
    public float vitesse = 2f;
    public float bords_Y = -7f;

    public bool moving_Platform_Left, moving_Platform_Right, is_Breakable, is_Spike, is_Platform;

    private Animator anim;

    void Awake()
    {
            if (is_Breakable)
            {
                anim = GetComponent<Animator>();
            }
               
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frames
    void Update()
    {
        DeplacementPlatform();


    }

    void DeplacementPlatform() 
    {
        Vector2 pos = transform.position;
        pos.y -= vitesse * Time.deltaTime;
        transform.position = pos;

        if (pos.y >= bords_Y)
        {
            gameObject.SetActive(false);
        }
    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            if (is_Spike)
            {
                target.transform.position = new Vector2(1000f, 1000f);
                //Sound_Manager.instance.GameOverSound();
                
            }

            if (is_Breakable)
            {
                //Sound_Manager.instance.LandSound();
                anim.Play("Break");
            }

            else if (is_Platform)
            {
                //Sound_Manager.instance.LandSound();
                anim.Play("Idle");
            }
        }
    }

    void breakableDeactivate()
    {
        Invoke("DeactivatePierreCassee", 0.5f);
    }

    void DeactivatePierreCassee()
    {
        //Sound_Manager.instance.IceBreakSound();
        gameObject.SetActive(false);
    }

    void OnCollisionStay2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            if (moving_Platform_Left)
            {
                target.gameObject.GetComponent<Player>().PlatformMove(-1f);
            }

            if (moving_Platform_Right)
            {
                target.gameObject.GetComponent<Player>().PlatformMove(1f);
            }
        }
    }
}
