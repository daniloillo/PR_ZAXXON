using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
 
{

    public float ShipSpeed;

    public float ShipSpeedX;

    public float ShipSpeedY;


    // Start is called before the first frame update
    void Start()
    {

        ShipSpeed = 60f;


        


    }

    // Update is called once per frame
    void Update()
    {
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
}
