using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float speed_Scroll = 0.3f;
    private MeshRenderer mesh_Renderer;
    


    void Awake ()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y -= Time.deltaTime * speed_Scroll;

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

    }
}
