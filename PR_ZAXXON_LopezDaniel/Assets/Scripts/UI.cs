using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class UI : MonoBehaviour
{
    [SerializeField] Image livesImage;
    [SerializeField] GameObject tutorialImage;
    [SerializeField] Sprite[] livesSprite;
    Variables variables;
    int vidas;
    
    int contadorInicio;



    // Start is called before the first frame update
    void Start()
    {
        
        vidas = 3;

        DetectorVidas();

        
        

    }

    // Update is called once per frame
    void Update()
    {
        Tutorial();

        

    }
    void DetectorVidas()
    {
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        vidas = variables.vidas;

        livesImage.sprite = livesSprite[vidas];

        

    }
    void  Tutorial()
    {
        bool buttA = Input.GetButtonDown("Accept");
        variables = GameObject.Find("Variables").GetComponent<Variables>();

        if (variables.initGame == true)
        {
            Time.timeScale = 0f;


        }


        if (buttA == true && contadorInicio == 0)
        {
            variables.initGame = false;

            contadorInicio++;

            Destroy(tutorialImage);

            StopCoroutine("Tutorial");
        }

        if(variables.initGame == false)
        {
            Time.timeScale = 1f;
        }

        else
        {
            
        }
    }  
}
