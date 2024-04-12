using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Input_Handler : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector2> _onMove = new();
    [SerializeField] public GameObject _lantern;
    public Rigidbody rb;
    public Animator animator;
    public bool playerIsOnGround = true;
    public bool _lanternOn = false;
    public GameObject _lanternParticle;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        _lantern.SetActive(false);
        animator = GetComponent<Animator>();

    }


    void Update()

    {

        _onMove?.Invoke(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("Run");

        } else if (Input.GetKeyDown("s"))
        {
            animator.SetTrigger("Run");

        } else if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Run");

        }
        else if (Input.GetKeyDown("d"))
        {
            animator.SetTrigger("Run");

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Run");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Run");

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Run");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger("Run");

        }
        if (Input.GetKeyDown("space") && playerIsOnGround)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            playerIsOnGround = false;
            animator.SetTrigger("Jump");

        }else if (Input.GetKeyDown("e") && (_lanternOn == false))
        {
            _lanternOn = true;
            _lantern.SetActive(true);
            Instantiate(_lanternParticle);
            
        }else if (Input.GetKeyDown("e") && (_lanternOn == true))
        {
            _lantern.SetActive(false);
            _lanternOn = false;

        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerIsOnGround = true;
        }
    }
}
