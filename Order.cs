using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    [SerializeField] Renderer[] characterRenderers; // �߰��� �κ�: characterRenderers ���� �߰�
    [SerializeField] Renderer[] backRenderers;
    [SerializeField] Renderer[] middleRenderers;
    //[SerializeField] Renderer[] topRenderers;
    [SerializeField] string sortingLayerName;
    int originOrder;

    private void Start()
    { 
        SetOrder(0);
    }


    public void SetOriginOrder(int originOrder)
    {
        this.originOrder = originOrder;
        SetOrder(originOrder);
    }

    public void SetMostFrontOrder(bool isMostFront)
    {
        SetOrder(isMostFront ? 100 : originOrder);
    }
    public void SetOrder(int order)
    {
        int mulOrder = order * 10;

        // �߰��� �κ�: �Ʒ� foreach�� �ϳ� �߰�(characterRenderers)
        foreach (var renderer in characterRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder - 1;
        }

        foreach (var  renderer in backRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder;
        }
        foreach(var renderer in middleRenderers)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = mulOrder + 4 ;  // �߰��� �κ�: ī�� ������ ������ layer ��ĥ��� +1���� +4�� ����
        }

    }

}