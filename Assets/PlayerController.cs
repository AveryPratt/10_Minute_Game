using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float rotateSpeed;
    public float moveSpeed;
    public float boundaryWidth;
    public float boundaryHeight;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Rotate(Vector3.forward, -horizontalInput * Time.deltaTime * rotateSpeed);

        if (verticalInput > 0)
        {
            transform.Translate(new Vector3(0, -verticalInput * moveSpeed, 0));
        }

        LimitToBoundary();
    }

    private void LimitToBoundary()
    {
        if (transform.position.x > boundaryWidth)
        {
            transform.position = new Vector3(boundaryWidth, transform.position.y);
        }
        if (transform.position.x < -boundaryWidth)
        {
            transform.position = new Vector3(-boundaryWidth, transform.position.y);
        }
        if (transform.position.y > boundaryHeight)
        {
            transform.position = new Vector3(transform.position.x, boundaryHeight);
        }
        if (transform.position.y < -boundaryHeight)
        {
            transform.position = new Vector3(transform.position.x, -boundaryHeight);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(0);
    }
}
