using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D m_rigidbody2D;
    public float m_jumpForce;
    public float m_fallForce;
    public float m_moveSpeed;

    public GameObject m_model;
    public Camera m_camera;


    public int m_jumpLimit;
    public int m_jumpsRemaining;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2D = m_model.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
        
        
        // Checking if touching ground


        if(Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody2D.AddForce((Vector3.right * m_moveSpeed) * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody2D.AddForce((Vector3.right * -1) * m_moveSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody2D.AddForce((Vector3.up * -1) * m_fallForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space)&& m_jumpsRemaining > 0)
        {
            RaycastHit hit;

            Vector3 p1 = transform.position;

            float radius = this.GetComponent<CircleCollider2D>().radius;

            if (Physics2D.OverlapCircle(p1, radius))
            {
                Debug.Log("Hit");
            }
            

            m_rigidbody2D.AddForce((transform.up * m_jumpForce) * Time.deltaTime, ForceMode2D.Impulse);
            m_jumpsRemaining -= 1;
        }

        // Camera movement - Removed for the time being.
        //Vector3 cameraPos = new Vector3(m_model.transform.position.x, m_model.transform.position.y, m_camera.transform.position.z);
        //m_camera.transform.position = cameraPos;



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            m_jumpsRemaining = m_jumpLimit;
        }
    }

    
}
