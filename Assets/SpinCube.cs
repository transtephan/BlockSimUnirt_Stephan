using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinCube : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("The block is at" + transform.position);
    }

    // Speed at which the cube moves
    public float speed = 10.0f;

    // Rotation speed of the cube
    public float rotationSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        // Get input from the user
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the cube in the direction of the input
        transform.position = transform.position + new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;

        // Rotate the cube if the space bar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }

        //Move the cube up/down (y-axis)
        if (Input.GetKey(KeyCode.W))
            transform.position = transform.position + new Vector3(0, 1, 0) * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position = transform.position + new Vector3(0, -1, 0) * speed * Time.deltaTime;

        //Debug.Log("The block is at" + transform.position);
       

    }

    void OnGUI()
    {
        //Debug.Log("Rect: " + new Rect(10, 10, 100, 20) + ", String: " + "Coordinates: " + transform.position);
        GUI.Label(new Rect(10, 10, 1000, 20), "Coordinates: " + transform.position);

        GUI.Label(new Rect(10, 25, 1000, 20), "Rotation: " + transform.eulerAngles);


        GUI.Label(new Rect(10, 40, 100, 100), "'w/s' = y \n'a/d' = x \n'up/down' = z \n'space/return' = rotate");
    }
}




