using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMove : MonoBehaviour
{
    Variables variables;
    Renderer rend;
    Vector2 despl;
    float scrollSpeed ;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        variables = GameObject.Find("Variables").GetComponent<Variables>();
    }

    // Update is called once per frame
    void Update()
    {
        TextureOffset();
    }

    void TextureOffset()
    {
        scrollSpeed = variables.ShipSpeed/3;
        float offset = (Time.time * scrollSpeed);
        despl = new Vector2(0f, -offset);
        rend.material.SetTextureOffset("_MainTex", despl);

    }
}
