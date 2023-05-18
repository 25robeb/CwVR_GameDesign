using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool Press;
    // Start is called before the first frame update
    void Start()
    {
        Press = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Press = true;
        }
    }
}
