using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
    private Collider2D coll;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (GetComponent<BoxCollider2D>() != null)
        {
            coll = GetComponent<BoxCollider2D>();
        }
        else if (GetComponent<CircleCollider2D>() != null)
        {
            coll = GetComponent<CircleCollider2D>();
        }
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PressurePlate"))
        {
            if (collision.GetComponent<ActivatePlate>() != null)
            {
                collision.GetComponent<ActivatePlate>().isActived = true;
            }
        }
    }
}
