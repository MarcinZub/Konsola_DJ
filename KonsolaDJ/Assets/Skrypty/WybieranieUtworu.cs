using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WybieranieUtworu : MonoBehaviour
{
    //Obiekt sprawdzający czy gracz patrzy na sfere.
    public Canvas utwory_wybor;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //Pobranie menu - Utwory
        utwory_wybor = (Canvas)GetComponent<Canvas>();
        //Ustawienie domyślnie wyłączeonego menu - Utwory
        utwory_wybor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.U)) //Menu pod klawiszem U
        {
            //Ukrywanie, pokazywanie menu Utwory
            utwory_wybor.enabled = !utwory_wybor.enabled;
            //Pokazanie myszy
            Cursor.visible = !utwory_wybor.enabled;

            if(utwory_wybor.enabled)
            {
                //Odblokowanie kursora
                Cursor.lockState = CursorLockMode.None;
                //Pokazanie kursora
                Cursor.visible = true;
                //Zatrzymanie tła gry
                Time.timeScale = 0;
            }
            else
            {
                //Zablokowanie mszy
                Cursor.lockState = CursorLockMode.Locked;
                //Ukrycie myszy
                Cursor.visible = false;
                //Włączenie tła gry
                Time.timeScale = 1;
            }
        }
    }
}
