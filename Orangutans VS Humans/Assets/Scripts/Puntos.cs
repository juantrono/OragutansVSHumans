using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    
    public Text textoContador;
    public static int puntuacion =0 ;
    // Start is called before the first frame update
    void Start()
    {
        textoContador.text = puntuacion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textoContador.text = puntuacion.ToString();
    }

    
    
        

   
        
    
}