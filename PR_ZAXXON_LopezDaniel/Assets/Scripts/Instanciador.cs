using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{



    
    [SerializeField] Transform initPos;
    
    float interval;
    Variables variables;
    [SerializeField] float distance;
    [SerializeField] GameObject[] objects;
    [SerializeField] GameObject[] arboles;
   


    // Start is called before the first frame update
    void Start()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        distance = 5f;
        interval = distance / variables.ShipSpeed;

        //INSTANCIADORES OBJETOS/OBSTACULOS
        StartCoroutine("InstanciadorObstaculos");
        

        //INSTANCIADORES LATERALES (ARBOLES MURO)
        float posInst = -10f;
        StartCoroutine("InstanciadorL");
        StartCoroutine("InstanciadorR");
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
        //INSTANCIADOR TRONCOS INICIALES
        float posInst2 = 60f;
        while(posInst2 <= 560f)
        {
            float randomX = Random.Range(-21f, 21f);
            float randomY = Random.Range(-3f, 2f);

            Vector3 newPos = new Vector3(randomX, randomY, posInst2);
            Instantiate(objects[0], newPos, Quaternion.identity);
            posInst2 = posInst2 + 10f;
        }

        


    }

    // Update is called once per frame
    void Update()
    {
       

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


    



    IEnumerator InstanciadorObstaculos()
    {
        while (true)
        {

            
            if (variables.ShipSpeed <= 40f)
            {
                //INSTANCIADOR COLUMNAS
                float randomXC = Random.Range(-21f, 21f);
                float randomYC = Random.Range(-3f, 2f);

                Vector3 newPos = new Vector3(randomXC, randomYC, initPos.position.z);
                Instantiate(objects[0], newPos, Quaternion.identity);
                float rInterval = Random.Range(0.1f, 0.5f);
                yield return new WaitForSeconds(interval + rInterval);

            }
            
            else if ( variables.ShipSpeed <= 50f)
            {
                //INSTANCIADOR COLUMNAS
                float randomXC = Random.Range(-21f, 21f);
                float randomYC = Random.Range(-3f, 2f);

                Vector3 newPosC = new Vector3(randomXC, randomYC, initPos.position.z);
                Instantiate(objects[0], newPosC, Quaternion.identity);
                

                //INSTANCIADOR BELLOTAS
                float randomXB = Random.Range(-23f, 23f);
                float randomYB = Random.Range(0f, 8f);

                Vector3 newPosB = new Vector3(randomXB, randomYB, initPos.position.z);
                Instantiate(objects[1], newPosB, Quaternion.identity);

                float rIntervalB = Random.Range(0.1f, 0.3f);
                yield return new WaitForSeconds(interval + rIntervalB);



            }
            
            else if(variables.ShipSpeed <= 60f)
            {
                //INSTANCIADOR COLUMNAS
                float randomXC = Random.Range(-21f, 21f);
                float randomYC = Random.Range(-3f, 2f);

                Vector3 newPosC = new Vector3(randomXC, randomYC, initPos.position.z);
                Instantiate(objects[0], newPosC, Quaternion.identity);
                

                //INSTANCIADOR BELLOTAS
                float randomXB = Random.Range(-23f, 23f);
                float randomYB = Random.Range(1, 8f);

                Vector3 newPosB = new Vector3(randomXB, randomYB, initPos.position.z);
                Instantiate(objects[1], newPosB, Quaternion.identity);

           

                //INSTANCIADOR ARBOLES
                float randomXA = Random.Range(-20f, 20f);
                float randomYA = Random.Range(-2f, 0f);

                Vector3 newPos = new Vector3(randomXA, randomYA, initPos.position.z);
                Instantiate(objects[2], newPos, Quaternion.identity);

                float rIntervalA = Random.Range(0.1f, 0.3f);
                yield return new WaitForSeconds(interval + rIntervalA);
            }
            
            else
            {
                //INSTANCIADOR COLUMNAS
                float randomXC = Random.Range(-21f, 21f);
                float randomYC = Random.Range(-3f, 2f);

                Vector3 newPosC = new Vector3(randomXC, randomYC, initPos.position.z);
                Instantiate(objects[0], newPosC, Quaternion.identity);
                

                //INSTANCIADOR BELLOTAS
                float randomXB = Random.Range(-23f, 23f);
                float randomYB = Random.Range(3, 8f);

                Vector3 newPosB = new Vector3(randomXB, randomYB, initPos.position.z);
                Instantiate(objects[1], newPosB, Quaternion.identity);

                

                //INSTANCIADOR ARBOLES
                float randomXA = Random.Range(-20f, 20f);
                float randomYA = Random.Range(-2f, 0f);

                Vector3 newPosA = new Vector3(randomXA, randomYA, initPos.position.z);
                Instantiate(objects[2], newPosA, Quaternion.identity);

                

                //INSTANCIADOR TRONCOS
                float randomXT = Random.Range(-3f, 3f);

                Vector3 newPosT = new Vector3(randomXT, initPos.position.y, initPos.position.z);
                Instantiate(objects[3], newPosT, Quaternion.Euler(0f, 90f, 0f));
                float rIntervalT = Random.Range(0.1f, 0.3f);
                yield return new WaitForSeconds(interval + rIntervalT);
            }
            
        }
    }
   
    
 
}



