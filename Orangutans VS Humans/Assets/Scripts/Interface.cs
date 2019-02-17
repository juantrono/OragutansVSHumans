using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interface : MonoBehaviour
{
	
	public bool paused;
    public bool visible;
  
	public Animator AnimacionPausa;
	
    // Start is called before the first frame update
    void Start() 
    {
       AnimacionPausa = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        AnimacionPausa.SetBool("Visible", visible);

        
        if (Input.GetKeyDown("p") && paused == false) {

            visible = true;
            paused = true;       
            Time.timeScale = 0;
            
      
         	

         }
         else if (Input.GetKeyDown ("p") && paused == true) {
          
            paused = false;
          

            Time.timeScale = 1;

        }
    }

    public void cargarEscena() {
        Application.LoadLevel("OrangutansVSHumans");
    }

    public void jugar() {
    	paused = false;
    	Time.timeScale = 1;
    }
}
