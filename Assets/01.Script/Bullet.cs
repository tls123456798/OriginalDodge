using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // Åº¾Ë ÀÌµ¿ ¼Ó·Â
    private Rigidbody bulletRigidbody; // ÀÌµ¿¿¡ »ç¿ëÇÒ ¸®Áöµå¹Ùµğ ÄÄÆ÷³ÍÆ®
    
    void Start()
    {
        // °ÔÀÓ ¿ÀºêÁ§Æ®¿¡¼­ Rigidbody ÄÄÆ÷³ÊÆ®¸¦ Ã£¾Æ bulletRigidbody¿¡ ÇÒ´ç
        bulletRigidbody = GetComponent<Rigidbody>();
        // ¸®Áöµå¹ÙµğÀÇ ¼Óµµ = ¾ÕÂÊ ¹æÇâ * ÀÌµ¿ ¼Ó·Â
        bulletRigidbody.linearVelocity = transform.forward * speed;

        // 3ÃÊ µÚ¿¡ ÀÚ½ÅÀÇ °ÔÀÓ ¿ÀºêÁ§Æ® ÆÄ±«
        Destroy(gameObject, 3f);
    }

    
    void OnTriggerEnter(Collider other)
    {
        // ­wµ¹ÇÑ »ó´ë¹æ °ÔÀÓ ¿ÀºêÁ§Æ®°¡ Player ÅÂ±×¸¦ °¡Áø °æ¿ì
        if (other.tag == "Player")
        {
            // »ó´ë¹æ °ÔÀÓ ¿ÀºêÁ§Æ®¿¡¼­ PlayerController ÄÄÆ÷³ÍÆ® °¡Á®¿À±â
            PlayerController playerController = other.GetComponent<PlayerController>();

            // »ó´ë¹æÀ¸·ÎºÎÅÍ PlayerCotroller ÄÄÆ÷³ÍÆ®¸¦ °¡Á®¿À´Â µ¥ ¼º°øÇß¤§¸é
            if (playerController != null)
            {
                // »ó´ë¹æ PlayerController ÄÄÆ÷³ÍÆ®ÀÇ Die() ¸Ş¼­µå ½ÇÇà
                playerController.Die();
            }
        }
    }
}
