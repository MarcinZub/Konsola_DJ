using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //Obiekt odpowiedzialny za ruch gracza.
    public CharacterController characterControler;

    //Czulość myszki (Sensitivity)
    public float czuloscMyszki = 3.0f;
    public float myszGoraDol = 0.0f;
    //Zakres patrzenia w górę i dół.
    public float zakresMyszyGoraDol = 90.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterControler = GetComponent<CharacterController>();
        // Make the game run as fast as possible
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        myszka();
    }

    /**
     * Metoda odpowiedzialna za ruch myszką.
     */
    private void myszka()
    {
        //Pobranie wartości ruchu myszki lewo/prawo.
        // jeżeli wartość dodatnia to poruszamy w prawo,
        // jeżeli wartość ujemna to poruszamy w lewo.
        float myszLewoPrawo = Input.GetAxis("Mouse X") * czuloscMyszki;
        transform.Rotate(0, myszLewoPrawo, 0);

        //Pobranie wartości ruchu myszki góra/dół.
        // jeżeli wartość dodatnia to poruszamy w górę,
        // jeżeli wartość ujemna to poruszamy w dół.
        myszGoraDol -= Input.GetAxis("Mouse Y") * czuloscMyszki;

        //Funkcja nie pozwala aby wartość przekroczyła dane zakresy.
        myszGoraDol = Mathf.Clamp(myszGoraDol, -zakresMyszyGoraDol, zakresMyszyGoraDol);
        //Ponieważ CharacterController nie obraca się góra/dół obracamy tylko kamerę.
        Camera.main.transform.localRotation = Quaternion.Euler(myszGoraDol, 0, 0);
    }
}
