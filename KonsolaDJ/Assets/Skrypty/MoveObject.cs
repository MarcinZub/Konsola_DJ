using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float koordynaty;

    void OnMouseDown()
    {
        koordynaty = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        //koordynaty myszy x i y
        Vector3 punktMyszy = Input.mousePosition;

        //koordynaty obiektu na ekranie z
        punktMyszy.z = koordynaty;

        //konwertowanie zrozumiałe dla punktow swiata
        return Camera.main.ScreenToViewportPoint(punktMyszy);

    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

}
