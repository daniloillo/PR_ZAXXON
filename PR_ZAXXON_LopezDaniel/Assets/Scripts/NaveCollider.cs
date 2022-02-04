using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NaveCollider : MonoBehaviour
{
    Variables variables;
    UI ui;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        ui = GameObject.Find("UI Canvas").GetComponent<UI>();


    }
    void OnTriggerEnter(Collider other)
    {   
        
        if (other.gameObject.layer == 3 && variables.vidas > 0)
        {
            

        }
        if (variables.vidas == 0)
        {
            print("A MIMIR");
            SceneManager.LoadScene(2);

        }

    }
}
