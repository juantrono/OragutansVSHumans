﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Matar() {
        Puntos.puntuacion += 10;
        Destroy(gameObject);
    }
}
