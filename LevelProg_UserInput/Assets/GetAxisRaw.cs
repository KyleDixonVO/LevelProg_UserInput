using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxisRaw : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        transform.Translate(movementX, 0, 0);
        float movementY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, movementY);
    }
}
