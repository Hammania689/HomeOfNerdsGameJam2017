using UnityEngine;
using System.Collections;

public class PlatformCameraFollow : MonoBehaviour 
{
	public GameObject player;
	public Vector3 offset;

	void Update()
	{
		this.transform.position = Xpos ();
	}

	Vector3 Xpos()
	{
		Vector3 camTrans;
		camTrans = new Vector3(player.transform.position.x,0f,-10f);
		camTrans += offset;
		return camTrans;
	}
}

