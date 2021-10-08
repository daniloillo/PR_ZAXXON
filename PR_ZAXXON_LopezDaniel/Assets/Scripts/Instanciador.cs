using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{



    
    [SerializeField] GameObject columna;
    [SerializeField] Transform initPos;


    float interval;


    // Start is called before the first frame update
    void Start()
    {

        interval = 0.5f;

        StartCoroutine("CrearColumna");


    }

    // Update is called once per frame
    void Update()
    {




    }

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

