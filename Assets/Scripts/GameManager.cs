using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public int cambioDeEscena = 0;
    public TextMeshProUGUI numCambioScena;





    // Start is called before the first frame update
    void Start()
    {
        cambioDeEscena = PlayerPrefs.GetInt("TotalCambioEscena");

       


    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(PlayerPrefs.GetInt("TotalCambiosEscena"));
       Debug.Log( message: $"  {cambioDeEscena}");

        cambioDeEscena = PlayerPrefs.GetInt("TotalCambiosEscena");
        numCambioScena.text = $"has cambiado {cambioDeEscena} veces de escena";


    }

    public void BorrarRecord()

    { 
        PlayerPrefs.SetInt("TotalCambiosEscena",0);
    
    
    }

}
