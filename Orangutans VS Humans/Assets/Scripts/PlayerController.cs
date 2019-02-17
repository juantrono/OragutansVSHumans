using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D Mono;
    Animator animacion;
    public int vida = 3;
    public bool subir;
    public bool bajar;
    public bool lanzar;
    public int FuerzaMovimiento =  50;

    // Start is called before the first frame update
    void Start()
    {
        Mono = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator> ();
    
       
    }

    // Update is called once per frame
    void Update()
    {
        animacion.SetBool("Subir", subir);
        animacion.SetBool("Bajar", bajar);
        animacion.SetBool("Lanzar", lanzar);

        if (Input.GetKeyDown(KeyCode.Space)) {
            lanzar = true;
        } else { lanzar = false; }

            if (Input.GetKey(KeyCode.W)){
            Mono.AddForce (Vector2.up * FuerzaMovimiento);
           
            subir = true;
        } else {
            subir = false;
        }


        if(Input.GetKey(KeyCode.S)){
            Mono.AddForce (Vector2.up * -FuerzaMovimiento);

            bajar = true;
        } else { bajar = false; }

    }

    void OnTriggerStay2D(Collider2D Mo)
    {
        if (Mo.gameObject.CompareTag("BalaEnemigo"))
        {
            --vida;
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    
}
