using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 40.0f;

    public Transform[] desPosition;
    private bool isArrive1;
    private bool isArrive2;
    private bool isArrive3;

    private enum DriveMode
    {
        manual,
        automatic
    }
    DriveMode carMode = DriveMode.manual;

    public TextMeshProUGUI manualText;
    public TextMeshProUGUI autoText;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination1 = desPosition[0].position - transform.position;
        Vector3 destination2 = desPosition[1].position - transform.position;
        Vector3 destination3 = desPosition[2].position - transform.position;

        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            carMode = DriveMode.automatic;
            autoText.enabled = true;
            manualText.enabled = false;
            autoText.text = carMode + " is ON";
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            carMode = DriveMode.manual;
            autoText.enabled = false;
            manualText.enabled = true;
            manualText.text = carMode + " is ON";
        }

        /*[Header("Automatic Mode")]*/
        if (carMode == DriveMode.automatic)
        {
                if (isArrive1 == false)
                {
                    transform.position += destination1 * Time.deltaTime;
                    if (destination1.sqrMagnitude < 1)
                    {
                        isArrive1 = true;
                        transform.Rotate(0, 90.0f, 0f);
                    }
                }

                if (isArrive2 == false && isArrive1 == true)
                {
                    transform.position += destination2 * Time.deltaTime;
                    if (destination2.sqrMagnitude < 1)
                    {
                        isArrive2 = true;
                        transform.Rotate(0, 90.0f, 0f);
                    }
                }

                if (isArrive3 == false && isArrive1 & isArrive2 == true)
                {
                    transform.position += destination3 * Time.deltaTime ;
                    if (destination3.sqrMagnitude < 1)
                    {
                        isArrive3 = true;
                        transform.Rotate(0, -90.0f, 0f);
                    }
                }
            }
        
        //Manual Mode: 
        if(carMode == DriveMode.manual)
        {
            isArrive1 = false;
            isArrive2 = false;
            isArrive3 = false;
            transform.position += Vector3.forward * verticalInput * Time.deltaTime * moveSpeed + Vector3.right * horizontalInput * Time.deltaTime * moveSpeed;
        }
    }
}
