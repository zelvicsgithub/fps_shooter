using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attake_skript : MonoBehaviour
{
    Animator knife;

    private void Start()
    {
        knife = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) knife.SetBool("attake", true);
        else if (Input.GetMouseButtonUp(0)) knife.SetBool("attake", false);
    }
}
