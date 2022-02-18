using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{   public Material material;
    Variables variables;
    
    
    // Start is called before the first frame update
    void Start()
    {   //SKYBOX PARAMETROS INICIALES
        material.SetFloat("_SkyGradientExponent", 0.25f);
        material.SetFloat("_HorizonLineContribution", 0.25f);
        material.SetColor("_SkyGradientTop", new Vector4(0.3672017f, 0.09878961f, 0.5660378f, 1));

        //VariablesVelocidad
        variables = GameObject.Find("Variables").GetComponent<Variables>();

        
    }

    // Update is called once per frame
    void Update()
    {
        SkyboxChange();
    }

    void SkyboxChange()
    {


        if (variables.ShipSpeed == 50f)
        {
            //ANOCHECER SKYBOX
            material.SetFloat("_SkyGradientExponent", 1f);
        }
        else if (variables.ShipSpeed == 60f)
        {
            //ANOCHECER SKYBOX
            material.SetFloat("_SkyGradientExponent", 3f);


        }
        else if (variables.ShipSpeed == 70f)
        {
            //ANOCHECER SKYBOX
            material.SetFloat("_SkyGradientExponent", 15f);
            //LINEA HORIZONTE
            material.SetFloat("_HorizonLineContribution", 0f);
        }
        else if (variables.ShipSpeed <= 80f)     
        {   
            //COLOR SKYBOX
            material.SetColor("_SkyGradientTop",new Vector4(0.008009964f, 0.02833727f, 0.1886792f, 1));
        }
       

    }
}
