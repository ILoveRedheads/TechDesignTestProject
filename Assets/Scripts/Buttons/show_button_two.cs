using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_button_two : MonoBehaviour
{

    public GameObject root_tree = null;
    public GameObject switch_button = null;
    // Start is called before the first frame update
    void Start()
    {
        switch_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            BoxCollider2D coll = root_tree.GetComponent<BoxCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                switch_button.SetActive(true);
            }
        }


    }
}
