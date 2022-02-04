using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorArboles : MonoBehaviour
{
    float interval;
    Variables variables;
    [SerializeField] float distance;
    [SerializeField] Transform initPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("InstanciarArboles");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator InstanciarArboles()
    {
        while (true)
        {
            variables = GameObject.Find("Variables").GetComponent<Variables>();
            distance = 5f;
            interval = distance / variables.ShipSpeed;

            if (variables.ShipSpeed >= 50f)
            {
                float randomX = Random.Range(-23f, 23f);
                float randomY = Random.Range(3, 10f);

                Vector3 newPos = new Vector3(randomX, randomY, initPos.position.z);
                //Instantiate(variables.objects[2], newPos, Quaternion.identity);

                float rInterval = Random.Range(1f, 2f);
                yield return new WaitForSeconds(interval + rInterval);
            }
            else
            {
                print("Aun no instancio arboles");
            }

        }
    }
}
