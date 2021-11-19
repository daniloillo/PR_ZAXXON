using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class NaveMove : MonoBehaviour
{
    //VELOCIDAD
    float desplXSpeed;
    float desplYSpeed;
    Variables variables;
    





    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();

        desplXSpeed = variables.ShipSpeedX;
        desplYSpeed = variables.ShipSpeedY;


        
        Movimiento();
        

        
        



    }
    

    void Movimiento()
    {
       

        //INTERACTIVIDAD
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        

        //POSICION
        float posX = transform.position.x;
        float posY = transform.position.y;

        //ROTACION
        float limR = 0.2f;
        float rotZ = transform.rotation.z;

        //LIMITE HORIZONTAL
        float limX = 20f;
        

        //LIMITES VERTICALES
        float limYU = 8f;
        float limYD = 0f;

        


        if (desplX > 0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * desplX * desplXSpeed, Space.World);     
        }

        if (desplX < 0f)
        {   
            transform.Translate(Vector3.right * Time.deltaTime * desplX * desplXSpeed, Space.World);
        }

        if (rotZ >= -limR && rotZ <= limR)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * desplX * 100f);
           
        }
        if (rotZ < -limR) 
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, -limR, 1f);

        }
        else if (rotZ > limR) 
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, limR, 1f);

        }
       


        transform.Translate(Vector3.up * Time.deltaTime * desplY * desplYSpeed, Space.World);








        //LIMITES

        if (posX > limX && desplX > 0f)
        {

            transform.position = new Vector3(limX, transform.position.y, transform.position.z);

        }
        if (posX < -limX && desplX < 0f)
        {

            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);

        }
        if (posY > limYU && desplY > 0f)
        {

            transform.position = new Vector3(transform.position.x, limYU, transform.position.z);

        }
        if (posY < limYD && desplY < 0f)
        {
            transform.position = new Vector3(transform.position.x, limYD, transform.position.z);
        }

        
    }

}
