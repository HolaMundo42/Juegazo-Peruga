using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            // QuitGame();
            // Hacer esto cuando esté la confirmación
        }
    }

    public void QuitGame()
    {
        // Capaz hacer que te pida confirmación 

        Application.Quit();
    }
}
