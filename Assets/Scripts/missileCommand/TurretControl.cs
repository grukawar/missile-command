using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour
{
    public GameObject missile;
    public GameObject launchEffect;
    public float turnSpeed = 0;

    public Transform[] muzzlePositions;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
            transform.Rotate(Vector3.back * Input.GetAxis("Horizontal") * turnSpeed);
        if(Input.GetButtonDown("Jump"))
        {
           

            foreach (Transform theMuzzlePos in muzzlePositions)
            {
                GameObject bullet = (GameObject)Instantiate(missile, theMuzzlePos.position, theMuzzlePos.rotation);
                GameObject muzzleFire = (GameObject)Instantiate(launchEffect, theMuzzlePos.position, theMuzzlePos.rotation);
                Destroy(muzzleFire, 2.0f);
            }
            Instantiate(launchEffect, transform.position, Quaternion.identity);
        }

	}

    
}
