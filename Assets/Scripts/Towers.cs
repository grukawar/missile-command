using UnityEngine;
using System.Collections;

public class Towers : health
{
    public GameObject shieldHit;

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(shieldHit, transform.position, Quaternion.identity);
            integrity = integrity - 1;
            DisplayHealth.count -= integrityValue;
            if (integrity <= 0)
            {
                dead = true;
                Instantiate(destroyed, transform.position, Quaternion.identity);

                DestroyObject(gameObject);
            }
        }

    }
}
