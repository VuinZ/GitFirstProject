using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator CharAttack;

    void Start()
    {
     CharAttack = GetComponent<Animator>();

    }

    void Attack()
    {
        CharAttack.SetTrigger("goAttack");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
}
