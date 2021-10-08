using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
    public class SmoothFollow : MonoBehaviour
    {
        //VARIABLES INICIALES
        //Nuestro objetivo
        public Transform target;
        //Distancia en el plano x-z al objetivo
        public float distance = 6f;
        //Altura a la que se mueve la c�mara por encima del objetivo
        public float height = 3f;
        //Tiempo de reacci�n
        public float heightDamping = 8f;
        public float rotationDamping = 3f;
        [AddComponentMenu("Camera-Control/Smooth Follow")]
        void LateUpdate()
        {
            //Si no tenemos todav�a el target, detenemos la ejecuci�n
            if (!target) return;
            //Calculamos los par�metros deseados
            float wantedRotationAngle = target.eulerAngles.y;
            float wantedHeight = target.position.y + height;
            float currentRotationAngle = transform.eulerAngles.y;
            float currentHeight = transform.position.y;
            //Realizamos el giro en torno al eje y
            currentRotationAngle = Mathf.LerpAngle(currentRotationAngle,
            wantedRotationAngle, rotationDamping * Time.deltaTime);
            //Realizamos el cambio de altura
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping *
            Time.deltaTime);
            //Convertimos el angulo en rotaci�n
            var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
            //Ponemos la c�mara en el plano x z adecuado, segun la distancia indiada
            transform.position = target.position;
            transform.position -= currentRotation * Vector3.forward * distance;
            //Movemos la c�mara a la altura adecuada
            transform.position = new Vector3(transform.position.x, currentHeight,
            transform.position.z);
            //Apuntamos la c�mara siempre al objetivo, a�adiendo un peque�o offset
            var target2 = target.position + new Vector3(0, 2.02f, 0);
            transform.LookAt(target2);


        }

    }


