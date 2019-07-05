/*using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class WybieranieUtworuPrzeciaganie : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform rodzicUtwory;
    private Transform trans;
    //public menuElemTyp elemTyp = menuElemTyp.BRON;

    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 60;
        trans = GetComponent<Transform>();
        rodzicUtwory = trans.parent;

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Info w KONSOLI
        Debug.Log("OnBeginDrag");

        //throw new System.NotImplementedException();

        trans.SetParent(rodzicUtwory.parent);

        //Wyłączenie blokady promienia myszy
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        trans.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();

        Debug.Log("OnEndDrag");

        trans.SetParent(rodzicUtwory);

        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform getRodzicEq()
    {
        return rodzicUtwory;
    }

    public void setRodzic(Transform transform)
    {
        rodzicUtwory = trans;
    }
}
*/


public class EqElementType
{
    public static EqElementType BRON { get; internal set; }
}