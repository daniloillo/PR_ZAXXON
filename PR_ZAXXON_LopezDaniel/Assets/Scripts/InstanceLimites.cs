using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceLimites : MonoBehaviour

{
    [SerializeField] Transform initPos;
    float speed;
    float interval;
    Variables variables;
    [SerializeField] float distance;
    [SerializeField] GameObject[] arboles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("InstanciadorL");
        StartCoroutine("InstanciadorR");


        variables = GameObject.Find("Variables").GetComponent<Variables>();
        speed = variables.ShipSpeed;
        interval = distance / speed;
        float posInst = -10f;
        
        while (posInst <= 560f)
        {
            float rX1 = Random.Range(-35f, -25f);
            float rX2 = Random.Range(25f, 35f);
            Vector3 newPosL = new Vector3(rX1, initPos.position.y, posInst);
            Instantiate(arboles[0], newPosL, Quaternion.identity);
            Vector3 newPosR = new Vector3(rX2, initPos.position.y, posInst);
            Instantiate(arboles[0], newPosR, Quaternion.identity);
            posInst = posInst + 5f;




        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator InstanciadorL()
    {

        while (true)
        {

            float randomX = Random.Range(-30f, -25f);
            

            Vector3 newPos = new Vector3(randomX, initPos.position.y, initPos.position.z);
            Instantiate(arboles[0], newPos, Quaternion.identity);

            yield return new WaitForSeconds(0.1f);

        }
    }

    IEnumerator InstanciadorR()
    {

        while (true)
        {

            float randomX = Random.Range(25f, 30f);
            

            Vector3 newPos = new Vector3(randomX, initPos.position.y, initPos.position.z);
            Instantiate(arboles[0], newPos, Quaternion.identity);

            yield return new WaitForSeconds(0.1f);

        }
    }
}
    
