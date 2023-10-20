using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_attack : MonoBehaviour
{
    public GameObject green_ork = null;
    private Animator Green_Axe = null;

    // Start is called before the first frame update
    void Start()
    {
        Green_Axe = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool Jumping = false;

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            BoxCollider2D coll = green_ork.GetComponent<BoxCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                Jumping = true;
            }
        }

        Green_Axe.SetBool("Jumping", Jumping);



    }
}
