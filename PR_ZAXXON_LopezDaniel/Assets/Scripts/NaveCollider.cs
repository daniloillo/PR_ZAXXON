using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NaveCollider : MonoBehaviour
{
    Variables variables;
    UI ui;
    MeshCollider meshCollider;
    
    Animator animator;






    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        ui = GameObject.Find("UI Canvas").GetComponent<UI>();
        meshCollider = GameObject.Find("Nave").GetComponent<MeshCollider>();
        animator = GetComponent<Animator>();


    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.layer == 3 && variables.vidas > 0)
        {
            
            if (variables.golpeado == false  )
            {
                golpeCD();

                Invoke("ActivarMesh", 3f);

                
            }
         

        }
        if (variables.vidas == 0)
        {
            
            SceneManager.LoadScene(2);

        }
        
 
    }
    void golpeCD()
    {
        meshCollider.enabled = false;
        variables.golpeado = true;
        variables.vidas--;
        animator.SetBool("Golpeado", true);

    }

    void ActivarMesh()
    {

        meshCollider.enabled = true;
        variables.golpeado = false;
        animator.SetBool("Golpeado", false);

    }



}
