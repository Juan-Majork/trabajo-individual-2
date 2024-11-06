using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField] public AudioClip jump;
    [SerializeField] public AudioClip hitDied;

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private float horizontalInput;
    private int velocidadX = 10;
    private int velocidadY = 10;
    private bool canJump = false;
    public bool isAlive = true;

    public int cristalsExit = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
        audioSource = rb.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (isAlive)
        {
            rb.velocity = new Vector2(horizontalInput * velocidadX, rb.velocity.y);

            if(horizontalInput < 0) 
            {
                spriteRenderer.flipX = true;
            }
            if (horizontalInput > 0)
            {
                spriteRenderer.flipX = false;
            }
            animator.SetFloat("movimientoX", horizontalInput);
            animator.SetFloat("movimientoY", rb.velocity.y);
        }
        
        if (Input.GetKey("space") && canJump && isAlive)
        {
            audioSource.PlayOneShot(jump);
            rb.AddForce(Vector2.up * velocidadY, ForceMode2D.Impulse);
            canJump = false;    
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("suelo") && rb.velocity.y <= 0)
        {
            canJump = true;
        }
        if (collision.gameObject.CompareTag("pincho"))
        {
            audioSource.PlayOneShot(hitDied);
            isAlive = false;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cristal"))
        {
            cristalsExit++;
        }
        if (collision.gameObject.CompareTag("pincho"))
        {
            audioSource.PlayOneShot(hitDied);
            isAlive = false;
        }
    }

    public void checkCristals(int cristals)
    {
        cristals = cristalsExit;

        
    }
}
