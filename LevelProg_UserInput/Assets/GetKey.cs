using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public int movementType = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.W);
        Input.GetKey(KeyCode.A);
        Input.GetKey(KeyCode.S);
        Input.GetKey(KeyCode.D);

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            this.gameObject.transform.Translate(Vector3.back * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            this.gameObject.transform.Translate(Vector3.left * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * 5);
        }

    }

}

