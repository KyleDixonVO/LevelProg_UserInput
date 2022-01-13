using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public int movementType = 1;
    public bool getKey = true;
    public bool getKeyDown = false;
    public bool getAxis = false;
    public bool getAxisRaw = false;
    public bool keyDownForward;
    public bool keyDownBack;
    public bool keyDownLeft;
    public bool keyDownRight;
    // Start is called before the first frame update
    void Start()
    {
        MovementSwitcher();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            movementType++;
            if (movementType > 4)
            {
                movementType = 1;
            }

            MovementSwitcher();
        }

        if (getKeyDown == true)
        {
            if (Input.GetKeyDown(KeyCode.W) == true)
            {
                keyDownForward = true;
            }

            if (Input.GetKeyDown(KeyCode.S) == true)
            {
                keyDownBack = true;
            }

            if (Input.GetKeyDown(KeyCode.A) == true)
            {
                keyDownLeft = true;
            }

            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                keyDownRight = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if (getKeyDown == true)
        {
            if (keyDownForward == true)
            {
                this.gameObject.transform.Translate(Vector3.forward * 2);
            }

            if (keyDownBack == true)
            {
                this.gameObject.transform.Translate(Vector3.back * 2);
            }

            if (keyDownLeft == true)
            {
                this.gameObject.transform.Translate(Vector3.left * 2);
            }

            if (keyDownRight == true)
            {
                this.gameObject.transform.Translate(Vector3.right * 2);
            }

            keyDownForward = false;
            keyDownBack = false;
            keyDownLeft = false;
            keyDownRight = false;
        }

        if (getKey == true)
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

        if (getAxis == true)
        {
            float movementX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(movementX, 0, 0);
            float movementY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, 0, movementY);
        }

        if(getAxisRaw == true)
        {
            float movementX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
            transform.Translate(movementX, 0, 0);
            float movementY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, 0, movementY);
        }
    }

    public void MovementSwitcher()
    {
        switch (movementType)
        {
            case 1:
                getKey = true;
                getKeyDown = false;
                getAxis = false;
                getAxisRaw = false;
                break;

            case 2:
                getKey = false;
                getKeyDown = true;
                getAxis = false;
                getAxisRaw = false;
                break;

            case 3:
                getKey = false;
                getKeyDown = false;
                getAxis = true;
                getAxisRaw = false;
                break;

            case 4:
                getKey = false;
                getKeyDown = false;
                getAxis = false;
                getAxisRaw = true;
                break;

        }
    }
}
