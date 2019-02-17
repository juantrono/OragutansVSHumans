using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBanana : MonoBehaviour{  
    public Transform PosicionPlatano; 
    public Rigidbody2D PrefabPlatano;
    public Rigidbody2D PrefabCaca;
    public int FuerzaPlatano = 50;
    public int FuerzaCaca = 80;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }

         if(Input.GetKeyDown(KeyCode.T))
         {
            DispararCaca();
        }
    }

    void Disparar (){
        Rigidbody2D platanoDisparo = Instantiate(PrefabPlatano, PosicionPlatano.position, PosicionPlatano.rotation);
        platanoDisparo.AddForce(Vector2.right * FuerzaPlatano);
        
    }
    void DispararCaca ()
    {
        Rigidbody2D platanoDisparo = Instantiate(PrefabCaca, PosicionPlatano.position, PosicionPlatano.rotation);
        platanoDisparo.AddForce(Vector2.right * FuerzaCaca);
    }    

   
}
