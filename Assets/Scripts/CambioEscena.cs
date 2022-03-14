using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private GameManager gameManager;



    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        PlayerPrefs.SetInt("TotalCambiosEscena", PlayerPrefs.GetInt("TotalCambiosEscena")+1);

        
    }


}
