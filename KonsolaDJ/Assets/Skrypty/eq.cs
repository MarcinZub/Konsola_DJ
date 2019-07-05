using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class eq : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform rodziceEq;

    private Transform trans;

    public EqElementType elementTyp = EqElementType.BRON;

    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        rodziceEq = trans.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");

        trans.SetParent(rodziceEq.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");

        trans.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        trans.SetParent(rodziceEq);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public Transform getRodzicEq()
    {
        return rodziceEq;
    }

    public void setRodzic(Transform trans)
    {
        rodziceEq = trans;
    }
}
