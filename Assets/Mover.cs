using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    public int player;

    public enum JoyConRKey
    {
        None = KeyCode.None,

        A = KeyCode.JoystickButton0,
        B = KeyCode.JoystickButton2,
        X = KeyCode.JoystickButton1,
        Y = KeyCode.JoystickButton3,
        Plus = KeyCode.JoystickButton9,
        Home = KeyCode.JoystickButton12,

        R = KeyCode.JoystickButton14,
        ZR = KeyCode.JoystickButton15,

        SR = KeyCode.JoystickButton5,
        SL = KeyCode.JoystickButton4,

        // Joystick Horizontal = Joystick Axis 10.
        // Joystick Vertical = Joystick Axis 9.
    }

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float spdConst = .15f;

        // 
        if (player == 1)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal1") * spdConst, 0, Input.GetAxis("Vertical1") * spdConst), ForceMode.Impulse);

            // 
            if (Input.GetKeyDown(KeyCode.Joystick1Button15))
            {
                rb.AddForce(Vector3.up * 7, ForceMode.Impulse);
            }
        }
        else if (player == 2)
        {
            rb.AddForce(new Vector3(-Input.GetAxis("Horizontal2") * spdConst, 0, -Input.GetAxis("Vertical2") * spdConst), ForceMode.Impulse);

            // 
            if (Input.GetKeyDown(KeyCode.Joystick2Button15))
            {
                rb.AddForce(Vector3.up * 7, ForceMode.Impulse);
            }
        }

        // 
        if (transform.position.y < -25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
