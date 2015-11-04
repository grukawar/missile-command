using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject ExplosionBlastR;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Explode()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Instantiate(ExplosionBlastR, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
