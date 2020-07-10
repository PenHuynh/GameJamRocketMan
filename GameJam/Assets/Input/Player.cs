using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D m_rigidbody2D;
    public float m_jumpForce;
    public float m_fallForce;
    public float m_moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody2D.AddForce((transform.right * m_moveSpeed), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody2D.AddForce((transform.right * -1) * m_moveSpeed, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody2D.AddForce((transform.up * -1) * m_fallForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody2D.AddForce((transform.up * m_jumpForce), ForceMode2D.Impulse);
        }
        



    }
}
