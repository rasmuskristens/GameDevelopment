using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float timeValue = 0;
    bool canJumpAgain;
    Rigidbody rb;
    private Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
       
        canJumpAgain = false;
    }

    // Update is called once per frame
    void Update()
    {

		
        enemy = GameObject.Find("rasmus(Clone)").transform;
        float distance = Vector3.Distance(enemy.position, transform.position);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(Vector3.up, -50f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(Vector3.up, 50f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.W))
                {

                    transform.Translate(Vector3.right * 20f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(-Vector3.right * 20f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(Vector3.right * 20f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.Q))
                {
                    transform.Translate(Vector3.forward * 20f * Time.deltaTime);
                }

                if (Input.GetKey(KeyCode.E))
                {

                    transform.Translate(-Vector3.forward * 20f * Time.deltaTime);
                }
            
        }
		else
		{
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -50f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, 50f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(Vector3.right * 10f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector3.right * 10f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.right * 10f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Translate(Vector3.forward * 10f * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E))
            {

                transform.Translate(-Vector3.forward * 10f * Time.deltaTime);
            }

			

            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
                canJumpAgain = true;

            }
			else
			{
                canJumpAgain = false;
			}

			if (distance > 20) {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (canJumpAgain)
                    {
                        rb = gameObject.GetComponent<Rigidbody>();

                        rb.AddForce(new Vector3(0, (float)10f, 0), ForceMode.VelocityChange);
                    }

                    if (gameObject.transform.position.y < 3)
                    {
                        rb = gameObject.GetComponent<Rigidbody>();

                        rb.AddForce(new Vector3(0, (float)10f, 0), ForceMode.VelocityChange);

                        timeValue = 2;

                    }
                }

                





            }
        }
    }

	
}
