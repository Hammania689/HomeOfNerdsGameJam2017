using UnityEngine;
using System.Collections;

public class SlipperyIceMechanic : MonoBehaviour {


    public Vector2 slipperyIce = new Vector2(1,0);

    void OnTriggerStay2D(Collider2D other)
    {
        slipperyIce = IceFactor(other.GetComponent<Rigidbody2D>());
        other.GetComponent<Rigidbody2D>().AddForce(slipperyIce, ForceMode2D.Force);
    }
	

    Vector2 IceFactor(Rigidbody2D rb)
    {
        Vector2 iceFactor = new Vector3(0,0,0);
        if (rb.velocity.sqrMagnitude >= new Vector2(0, 0).sqrMagnitude)
            iceFactor = new Vector2(2, 0);
        else if (rb.velocity.sqrMagnitude <= new Vector2(-.1f, 0).sqrMagnitude)
            iceFactor = new Vector2(-2, 0);
        return iceFactor;
    }
}
