using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBellotas : MonoBehaviour
{
    float interval;
    Variables variables;
    [SerializeField] float distance;
    [SerializeField] Transform initPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("InstanciarBellotas");


    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator InstanciarBellotas()
    {
        while (true)
        {
            variables = GameObject.Find("Variables").GetComponent<Variables>();
            distance = 5f;
            interval = distance / variables.ShipSpeed;


            if (variables.ShipSpeed >= 40f)
            {
                float randomX = Random.Range(-23f, 23f);
                float randomY = Random.Range(3, 10f);

                Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
                //Instantiate(variables.objects[1], newPos, Quaternion.identity);


                yield return new WaitForSeconds(interval + 1f);
            }
            else
            {
                print("Aun no instancio bellotas");
            }

        }
    }
}
