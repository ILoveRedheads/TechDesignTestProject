using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_script : MonoBehaviour
{
    public GameObject ork_spritesheet = null;
    private Animator Ork = null;

    // Start is called before the first frame update
    void Start()
    {
        Ork = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool  Attacking = false;

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            BoxCollider2D coll = ork_spritesheet.GetComponent<BoxCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                Attacking = true;
            }
        }

        Ork.SetBool("Attacking", Attacking);



    }
}
