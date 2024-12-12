using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMyInventory : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Vector2 offset;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>(); // �г��� RectTransform�� ������
    }

    // ���콺�� ������ �� ȣ��Ǵ� �Լ�
    public void OnPointerDown(PointerEventData eventData)
    {
        // �г��� ��ġ�� ���콺 Ŭ�� ��ġ ���̸� ���
        RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out offset);
    }

    // ���콺�� �巡���� �� ȣ��Ǵ� �Լ�
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mousePos;
        // ���� ���콺 ��ġ�� ���� ��ǥ�� ��ȯ
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform.parent as RectTransform, eventData.position, eventData.pressEventCamera, out mousePos))
        {
            rectTransform.localPosition = mousePos - offset; // �г� �̵�
        }
    }
}
