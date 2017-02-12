using UnityEngine;
using System.Collections;

public class BallExample : MonoBehaviour {

    public PlayerController playerController;
    public PlatformCameraFollow platCam;
    public Camera cam;
    public GameObject iceBall;
    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine("CinematicExample");
        rb.isKinematic = false;
        //cam.transform.position += offset * Time.deltaTime;
    }


    IEnumerator CinematicExample()
    {

        Vector3 offset = new Vector3(3,0);

        playerController.enabled = false;
        platCam.enabled = false;
        Vector3.MoveTowards(cam.transform.position, (cam.transform.position += offset),offset.sqrMagnitude);

        yield return new WaitForSeconds(8f);
        playerController.enabled = true;
        platCam.enabled = true;
    }
}
