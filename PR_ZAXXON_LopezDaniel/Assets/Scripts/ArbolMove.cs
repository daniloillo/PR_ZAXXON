using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolMove : MonoBehaviour
{

    float ObjSpeed;
    float limite;
    Variables variables;
        


    public object Speed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        //Valor de Velocidad de Nave desde el Scrip "Variables"

        variables = GameObject.Find("Variables").GetComponent<Variables>();

        ObjSpeed = variables.ShipSpeed;

        // EN QUE PUNTO DEL EJE Z DESAPARECEN

        limite = -15f;
    }

    // Update is called once per frame
    void Update()
    {
         

        //MOVIMIENTO

        transform.Translate(Vector3.up * Time.deltaTime * ObjSpeed);

        //DESTRUIR ELEMENTOS

        if(transform.position.z <= limite)
        {

            Destroy(gameObject);
                


        }
        
    }


}
