using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_button_one : MonoBehaviour
{

    public GameObject tree = null;
    public GameObject escape_button = null;
    // Start is called before the first frame update
    void Start()
    {
        escape_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            BoxCollider2D coll = tree.GetComponent<BoxCollider2D>();

            if (coll.OverlapPoint(wp))
            {
                escape_button.SetActive(true);
            }
        }


    }
}
