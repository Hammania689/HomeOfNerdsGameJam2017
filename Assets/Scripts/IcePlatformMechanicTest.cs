using UnityEngine;
using System.Collections;

public class IcePlatformMechanicTest : MonoBehaviour
{
    public Vector3 newPos;
    public Vector3 playerPushForce, maxVelocity;

    void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("will kill");
            other.transform.position = newPos;
            PlayerVelocityManipulation(other);
    }

    void PlayerVelocityManipulation(Collider2D other)
    {
        Rigidbody2D rb;

        rb = other.gameObject.GetComponent<Rigidbody2D>();
        maxVelocity = new Vector2(1.4f, 1.3f);

        float maxMagnitude = maxVelocity.sqrMagnitude;
        maxMagnitude = Mathf.Clamp(rb.velocity.sqrMagnitude, 0, maxMagnitude);

        playerPushForce = new Vector3(3, 2, 0);
        rb.AddForceAtPosition(playerPushForce, newPos, ForceMode2D.Impulse);
        rb.velocity = new Vector2(maxMagnitude, maxMagnitude);
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(newPos, 1.2f);
    }
}



