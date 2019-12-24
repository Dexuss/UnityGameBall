using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalCollider : MonoBehaviour
{
    public GameObject particles;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name != "Sphere") {
            return;
        }
        if(leaveCrystals() == 1)
        {
            Application.LoadLevel("win");
        }
        else
        {
            Instantiate(particles, transform.position,Quaternion.identity);
            Destroy(gameObject, 0.1f);
        } 
    }

    int leaveCrystals()
    {
        CrystalCollider[] crystals = Component.FindObjectsOfType<CrystalCollider>();
        return crystals.Length;
    }
}
