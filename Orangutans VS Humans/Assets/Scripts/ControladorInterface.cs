using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInterface : MonoBehaviour
{
    public Animator animacionPausa;
    public bool pausa = false;
    public bool visible;
    public bool invisible;
    // Start is called before the first frame update
    void Start()
    {
        animacionPausa = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animacionPausa.SetBool("Visible", visible);
        animacionPausa.SetBool("Invisible", invisible);
        if (Input.GetKeyDown(KeyCode.P))
        {
            visible = true;
        }

            if (Input.GetKeyDown(KeyCode.P))
        {
            
            pausa = !pausa;
            
        }

        if (pausa)
        {
            Time.timeScale = 0f;
           
        }
        else
        {
            visible = false;
            Time.timeScale = 1f;
           
        }
    }

    public void cargarEscena()
    {
        Application.LoadLevel("OrangutansVSHumans");
    }

    public void jugar()
    {
        pausa = false;
        Time.timeScale = 1;
    }

}
