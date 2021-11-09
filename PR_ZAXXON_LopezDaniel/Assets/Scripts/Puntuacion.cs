using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public static int score;
    public Text puntuacion;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()    
    {
        puntuacion.text = score.ToString();
        StartCoroutine("Contador");
    }
    IEnumerator Contador()
    {
        score = score + 1;

        yield return new WaitForSecondsRealtime(1f);

    }
    
}
