using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorEnemigo : MonoBehaviour
{
    public Transform PosicionDisparadorEnemigo;
    public Rigidbody2D PrefabBalaEnemigo;

    public int FuerzaBalaEnemigo = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        Rigidbody2D platanoDisparo = Instantiate(PrefabBalaEnemigo, PosicionDisparadorEnemigo.position, PosicionDisparadorEnemigo.rotation);
        platanoDisparo.AddForce(Vector2.right * FuerzaBalaEnemigo);
    }
}
