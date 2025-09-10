using UnityEngine;

public class BlueBullet : MonoBehaviour
{
    public float speed = 8f; // 탄알 이동 속력
    private Rigidbody bluebulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트

   
    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 BlueBulletRigidbody에 할당
        bluebulletRigidbody = GetComponent<Rigidbody>();
        // 리지드바디의 속도 = 앞쪽 방향 * 이동 속력
        bluebulletRigidbody.linearVelocity = transform.forward * speed;

        // 3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3f);
    }

    
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 Enemy 태그를 가진 경우
        if (other.tag == "Enemy")
        {
            // 상대방 게임 오브젝트에서 BulletSpawner 컴포넌트 가져오기
            BulletSpawner bulletSpawner = other.GetComponent<BulletSpawner>();

            // 상대방으로부터 BulletSpawner 컴폰너트를 가져오는 데 성공했다면
            if (bulletSpawner != null)
            {
                // 상대방 BulletSpawner 컴폰너트의 Die() 메서드 실행
                bulletSpawner.Die();
            }
        }
    }
}
