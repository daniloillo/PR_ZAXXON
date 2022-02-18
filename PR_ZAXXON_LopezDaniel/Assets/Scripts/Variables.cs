using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Variables : MonoBehaviour
 
{
    public int vidas;

    public bool muerte = false;

    public float ShipSpeed;

    public float ShipSpeedX;

    public float ShipSpeedY;

    public bool initGame = true;

    public bool golpeado = false;

    

    public int nivel;

    [SerializeField] GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {

        vidas = 3;

        StartCoroutine("AumentadorSpeed");
        ShipSpeed = 30f;




    }

    // Update is called once per frame
    void Update()
    {
        //Ajuste Velocidad tras Golpe

        if (Time.timeScale == 1f)
        {
            if (golpeado == true)
            {
                ShipSpeed = 20f;

            }
            else
            {
                velocidadNivel();
            }

        }

        print(ShipSpeed);

        //Controlador de Velocidad de la Nave en X e Y de forma independiente mediante la Velocidad de la Nave

        if (ShipSpeedX < 60f && ShipSpeed < 150f)
        {
            ShipSpeedX = (ShipSpeed * 0.4f);
            

            if (ShipSpeedX >= 60f)
            {
                ShipSpeedX = 60f;

            }
            else if (ShipSpeedY < 30f && ShipSpeed < 100f)
            {
                ShipSpeedY = (ShipSpeed * 0.3f);

                if (ShipSpeedY >= 30f)
                {
                    ShipSpeedY = 30f;

                }
            }

        }
     
    }

    IEnumerator AumentadorSpeed()
    {
        while (ShipSpeed < 80f && Time.timeScale == 1f)
        {
           //Pasa de Nivel cada 20 segundos
            nivel++;
            yield return new WaitForSeconds(20f);
            

        }

    }

    //Ajuste de Velocidad cada Nivel
    void velocidadNivel()
    {
        if (nivel == 1)
        {
            ShipSpeed = 40f;
        }
        else if (nivel == 2)
        {
            ShipSpeed = 50f;
        }
        else if (nivel == 3)
        {
            ShipSpeed = 60f;
        }
        else if (nivel == 4)
        {
            ShipSpeed = 70f;
        }
        else
        {
            ShipSpeed = 80f;
        }
    }
    

}
