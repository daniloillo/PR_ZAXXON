using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Botones : MonoBehaviour
{
    int[] scenes;

    public AudioMixer audioMixer;
   
    public void Menu()
    {
        SceneManager.LoadScene(0);
        //Reanuda Musica Men� (Si venimos de la escena GameOver)
        MusicScript.inst.Reanudar();
    }
    public void InitGame()
    {
        SceneManager.LoadScene(1);
        //Pausar Musica Men�
        MusicScript.inst.Pausar();
    }
    public void Options()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
       Application.Quit();
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
    }
}
