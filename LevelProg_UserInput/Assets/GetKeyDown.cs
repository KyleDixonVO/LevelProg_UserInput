using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKeyDown(KeyCode.W);
        Input.GetKeyDown(KeyCode.A);
        Input.GetKeyDown(KeyCode.S);
        Input.GetKeyDown(KeyCode.D);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * 5);
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * 5);
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
    }
}
