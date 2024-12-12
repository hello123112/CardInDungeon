using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleOrder : MonoBehaviour
{
    [SerializeField] private Renderer[] renderers; // ��ƼŬ ������ �迭
    private List<int> particleOriginalOrders = new List<int>(); // ���� sortingOrder ���� ����Ʈ
    private ParticleSystem[] particleSystems;

    // Start is called before the first frame update
    void Start()
    {
        // ������ �迭�� ���Ե� ��ƼŬ �ý����� sortingOrder ����
        foreach (Renderer renderer in renderers)
        {
            ParticleSystemRenderer particleRenderer = renderer.GetComponent<ParticleSystemRenderer>();

            if (particleRenderer != null)
            {
                particleOriginalOrders.Add(particleRenderer.sortingOrder);
                particleRenderer.sortingOrder += 1000; // ���� sortingOrder�� 1000 ���� ���� ���� ǥ��
            }
            else
            {
                particleOriginalOrders.Add(0); // ��ƼŬ �������� ���� ��� �⺻��
            }
        }
    }

    // ���� ���߿� sortingOrder�� ������� �����ϰ� �ʹٸ� �� �Լ��� �߰��� �� ����
    public void RestoreOriginalOrder()
    {
        for (int i = 0; i < renderers.Length; i++)
        {
            ParticleSystemRenderer particleRenderer = renderers[i].GetComponent<ParticleSystemRenderer>();
            if (particleRenderer != null)
            {
                particleRenderer.sortingOrder = particleOriginalOrders[i]; // ���� sortingOrder�� ����
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }



}
