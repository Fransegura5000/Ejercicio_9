using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private float speed = 7f;
    private float horizontalImput;
    private float verticalInput;

    public float PosX;
    public float PosY;
    public float PosZ;

    public Vector3 posicion;

    // public Vector3 initialPos = Vector3.zero; de momento no se usa.



    void Start()
    {

        CargarPosicion();


    }

    // Update is called once per frame
    void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalImput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);

        GuardarPosicion();





    }


    public void GuardarPosicion()
    {
        PlayerPrefs.SetFloat("PosicionX", transform.position.x);
        PlayerPrefs.SetFloat("PosicionY", transform.position.y);
        PlayerPrefs.SetFloat("PosicionZ", transform.position.z);


    }

    public void CargarPosicion()
    {
        PosX = PlayerPrefs.GetFloat("PosicionX");
        PosY = PlayerPrefs.GetFloat("PosicionY");
        PosZ = PlayerPrefs.GetFloat("PosicionZ");

        posicion.x = PosX;
        posicion.y = PosY;
        posicion.z = PosZ;

        transform.position = posicion;

    }







}
