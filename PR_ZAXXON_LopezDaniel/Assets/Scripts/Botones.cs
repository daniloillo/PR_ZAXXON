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
    }
 
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
}
