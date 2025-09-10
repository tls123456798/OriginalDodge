using UnityEngine;

public class BlueBullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵� �ӷ�
    private Rigidbody bluebulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ

   
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� BlueBulletRigidbody�� �Ҵ�
        bluebulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bluebulletRigidbody.linearVelocity = transform.forward * speed;

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    
    void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Enemy �±׸� ���� ���
        if (other.tag == "Enemy")
        {
            // ���� ���� ������Ʈ���� BulletSpawner ������Ʈ ��������
            BulletSpawner bulletSpawner = other.GetComponent<BulletSpawner>();

            // �������κ��� BulletSpawner ������Ʈ�� �������� �� �����ߴٸ�
            if (bulletSpawner != null)
            {
                // ���� BulletSpawner ������Ʈ�� Die() �޼��� ����
                bulletSpawner.Die();
            }
        }
    }
}
