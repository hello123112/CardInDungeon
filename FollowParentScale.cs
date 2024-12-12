using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParentScale : MonoBehaviour
{
    private Transform parentTransform;

    void Start()
    {
        // �θ� ������Ʈ�� Transform�� ����
        parentTransform = transform.parent;
    }

    void LateUpdate()
    {
        if (parentTransform != null)
        {
            // �θ� ������Ʈ�� �������� �ڽ� ������Ʈ�� ����
            transform.localScale = parentTransform.lossyScale;
        }
    }
}
