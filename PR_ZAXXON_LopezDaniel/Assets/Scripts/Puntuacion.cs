using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    Variables variables;
    public static float score;
    public Text puntuacion;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        

        score = 0;
        
        
    }

    // Update is called once per frame
    void Update()    
    {
        bool buttA = Input.GetButtonDown("Accept");
        puntuacion.text = score.ToString();
        if(buttA == true)
        {
            StartCoroutine("Contador");
        }
        
    }
    IEnumerator Contador()
    {
        while (true)
        {   
            variables = GameObject.Find("Variables").GetComponent<Variables>();
            if(variables.initGame==false)

            speed = variables.ShipSpeed;

            score = score + 1f * speed  ;

            yield return new WaitForSeconds(0.1f);

        }
        

    }
    
}
