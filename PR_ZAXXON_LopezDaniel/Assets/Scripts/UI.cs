using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class UI : MonoBehaviour
{
    public Image livesImage;
    [SerializeField] GameObject tutorialImage;
    public Sprite[] livesSprite;
    Variables variables;
    [SerializeField] Image[] uiButtons;
    
    
    int contadorInicio;



    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        Tutorial();
        DetectorVidas();


    }
    void DetectorVidas()
    {      
        variables = GameObject.Find("Variables").GetComponent<Variables>();
        

        livesImage.sprite = livesSprite[variables.vidas];
        
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
            Destroy(uiButtons[0]);
            Destroy(uiButtons[1]);

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
