using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{



    
    [SerializeField] Transform initPos;
    float speed;
    float interval;
    Variables variables;
    [SerializeField] float distance;
    [SerializeField] GameObject[] objects;


    // Start is called before the first frame update
    void Start()
    {

        distance = 15f;

        StartCoroutine("CrearColumna");
        StartCoroutine("CrearBellota");
        StartCoroutine("CrearArbol");

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
            float randomY = Random.Range(-3f, 2f);
            float randomZr = Random.Range(-40f, 40f);

            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[0], newPos, Quaternion.Euler(-90f, 0f, 0f));

            yield return new WaitForSeconds(interval);





        }






    }
    IEnumerator CrearBellota()
    {

        while (true)
        {


            float randomX = Random.Range(-23f, 23f);
            float randomY = Random.Range(3, 10f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[1], newPos, Quaternion.identity);

            yield return new WaitForSeconds(interval + 1f);





        }

    }
    IEnumerator CrearArbol()
    {

        while (true)
        {


            float randomX = Random.Range(-20f, 20f);
            float randomY = Random.Range(-5f, -1f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[2], newPos, Quaternion.Euler(-90f, 0f, 0f));

            yield return new WaitForSeconds(interval + 2f);





        }

    }
}



