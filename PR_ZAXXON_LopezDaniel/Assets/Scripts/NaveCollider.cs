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

    AudioSource audioSource;

    [SerializeField] ParticleSystem explosion;


    // Start is called before the first frame update
    void Start()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        ui = GameObject.Find("UI Canvas").GetComponent<UI>();
        meshCollider = GameObject.Find("Nave").GetComponent<MeshCollider>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.layer == 3 && variables.vidas > 0)
        {
            
            if (variables.golpeado == false  )
            {
                golpeCD();

                Invoke("ActivarMesh", 3f);

                audioSource.PlayOneShot(audioSource.clip, 1f);
                
            }
         

        }
        if (variables.vidas == 0)
        {

            Invoke("CargarEscenaMuerte", 3);
            explosion.Play();
            meshCollider.enabled = false;           
            animator.SetTrigger("Muerte");

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

    void CargarEscenaMuerte()
    {
        SceneManager.LoadScene(2);
    }



}
