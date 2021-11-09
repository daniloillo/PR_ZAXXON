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
    [SerializeField] GameObject[] arboles;


    // Start is called before the first frame update
    void Start()
    {

        distance = 15f;
        StartCoroutine("InstanciadorL");
        StartCoroutine("InstanciadorR");
        StartCoroutine("CrearColumna");
        StartCoroutine("CrearBellota");
        StartCoroutine("CrearArbol");
        StartCoroutine("CrearTronco");

        //Valor de Velocidad de Nave desde el Scrip "Variables"

        variables = GameObject.Find("Variables").GetComponent<Variables>();

        speed = variables.ShipSpeed;

        interval = distance / speed;

        float posInst = -10f;

        while (posInst <= 560f)
        {
            float lX1 = Random.Range(-32f, -27f);
            float lX2 = Random.Range(-37f, -32f);
            float rX1 = Random.Range(27f, 32f);
            float rX2 = Random.Range(32f, 37f);
            Vector3 newPosL1 = new Vector3(lX1, -4f, posInst);
            Vector3 newPosL2 = new Vector3(lX2, -4f, posInst);
            Instantiate(arboles[0], newPosL1, Quaternion.identity);
            Instantiate(arboles[0], newPosL2, Quaternion.identity);
            Vector3 newPosR1 = new Vector3(rX1, -4f, posInst);
            Vector3 newPosR2 = new Vector3(rX2, -4f, posInst);
            Instantiate(arboles[0], newPosR1, Quaternion.identity); 
            Instantiate(arboles[0], newPosR2, Quaternion.identity);
            posInst = posInst + 5f;

        }


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
            float rInterval = Random.Range(0f, 2f);

            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[0], newPos, Quaternion.Euler(-90f, 0f, 0f));

            yield return new WaitForSeconds(interval + rInterval);

        }

    }
    IEnumerator CrearBellota()
    {

        while (true)
        {


            float randomX = Random.Range(-23f, 23f);
            float randomY = Random.Range(3, 10f);
            float rInterval = Random.Range(0.5f, 2f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[1], newPos, Quaternion.identity);

            yield return new WaitForSeconds(interval + rInterval);

        }

    }
    IEnumerator CrearArbol()
    {

        while (true)
        {


            float randomX = Random.Range(-20f, 20f);
            float randomY = Random.Range(-5f, -1f);
            float rInterval = Random.Range(1f, 4f);
            Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
            Instantiate(objects[2], newPos, Quaternion.Euler(-90f, 0f, 0f));

            yield return new WaitForSeconds(interval + rInterval);

        }

    }

    IEnumerator CrearTronco()
    {

        while (true)
        {


            float randomX = Random.Range(-3f, 3f);
            float rInterval = Random.Range(2f, 5f);
            Vector3 newPos = new Vector3(randomX, initPos.position.y, initPos.position.z);
            Instantiate(objects[3], newPos, Quaternion.Euler(0f, 90f, -90f));

            yield return new WaitForSeconds(interval+ rInterval);

        }

    }
    IEnumerator InstanciadorL()
    {

        while (true)
        {

            float randomX1 = Random.Range(-32f, -27f);
            float randomX2 = Random.Range(-37f, -32f);


            Vector3 newPos1 = new Vector3(randomX1, -4f, initPos.position.z);
            Vector3 newPos2 = new Vector3(randomX2, -4f, initPos.position.z);
            Instantiate(arboles[0], newPos1, Quaternion.identity);
            Instantiate(arboles[0], newPos2, Quaternion.identity);

            yield return new WaitForSeconds(0.13f);

        }
    }

    IEnumerator InstanciadorR()
    {

        while (true)
        {

            float randomX1 = Random.Range(27f, 32f);
            float randomX2 = Random.Range(32f, 37f);


            Vector3 newPos1 = new Vector3(randomX1, -4f, initPos.position.z);
            Vector3 newPos2 = new Vector3(randomX2, -4f, initPos.position.z);
            Instantiate(arboles[0], newPos1, Quaternion.identity);
            Instantiate(arboles[0], newPos2, Quaternion.identity);

            yield return new WaitForSeconds(0.13f);

        }
    }
}



