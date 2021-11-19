using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NaveCollider : MonoBehaviour
{
    Variables variables;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        
    }
    void OnTriggerEnter(Collider other)
    {   
        
        if (other.gameObject.layer == 3 && variables.vidas > 0)
        {
            variables.vidas--;
            print("hit");
        }
        if (variables.vidas == 0)
        {
            print("A MIMIR");

        }

    }
}
