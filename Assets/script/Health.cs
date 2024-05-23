using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int heal;
    public int maxheal;

    public void TakeHit(int Damage)
    {
        heal -= Damage;

        if (heal <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Setheal(int bonusheal)
    {
        heal += bonusheal;

        if (heal > maxheal)
        {
            heal = maxheal;
        }
    }
}
