using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{



    
    [SerializeField] GameObject columna;
    [SerializeField] Transform initPos;

    float speed;
    float interval;
    Variables variables;
    [SerializeField] float distance;


    // Start is called before the first frame update
    void Start()
    {

        distance = 15f;

        StartCoroutine("CrearColumna");

        //Valor de Velocidad de Nave desde el Scrip "Variables"

        variables = GameObject.Find("Variables").GetComponent<Variables>();

        speed = variables.ShipSpeed;

        interval = distance / speed;


    }

    // Update is called once per frame
    void Update()
    {




    }


    //GENERADOR DE COLUMNAS
    IEnumerator CrearColumna()
    {

        while (true)
        {
            

            float randomX = Random.Range(-23f, 23f);
            float randomY = Random.Range(0, 7f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(interval);





        }






    }
   








}

