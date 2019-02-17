using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCaca : MonoBehaviour
{
    public float radioArea = 5f;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            area ();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void area ()
    {
        Collider2D[] enemigosArea;
        enemigosArea = Physics2D.OverlapCircleAll(transform.position, radioArea, LayerMask.GetMask("Enemigo"));


        for(int contador = 0; contador < enemigosArea.Length; contador++){
            enemigosArea[contador].gameObject.GetComponent<Muerte>().Matar() ;
        }
    }

}
