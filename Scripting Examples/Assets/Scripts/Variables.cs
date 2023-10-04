using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Public Global/Member Variables
    public int score = 0; // declare a whole number
    public float ItemAmount = 19.95f; // declare a decimal number
    public string PlayerName = "John Doe"; // declare a text
    public bool IsPlayerActive = true; // declare a true/false

    // private Global/Member Variables
    private int _collectibleAmount = 0;
    private float _horizontalInput = 0f;
    private string _userName = "john007";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // make sure Score Variable is = 0 
        score = 0; // assigning a Global/Member variable

        // declare a local variable to track Start Position
        Vector3 startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // trying to update a local variables value
        // we can not update a local variable
        //startPoision = new Vector3(Vector3.right);

        // create a variable to determine object key movement
        float verticalInput = Input.GetAxis("Vertical");
    }
}
