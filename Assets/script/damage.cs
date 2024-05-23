using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int Damage = 10;
    public string colltag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == colltag)
        {
            Health heal = collision.gameObject.GetComponent<Health>();
            heal.TakeHit(Damage);
        }
    }
}
