using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : Unit
{

    [SerializeField]

    public Vector2 curSavePos ;

    public int lives = 5;

    public int Lives
    {
        get { return lives; }
        set
        {
            if (value < 5) lives = value;
            livesBar.Refresh();
        }
    }

    private LivesBar livesBar;


    [SerializeField]
    private float speed = 2.0F;

    [SerializeField]
    private float jumpForce = 10.0F;

  
    public CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int) value); }
    }
    new private Rigidbody2D rigidbody;
    private Animator animator;
    private SpriteRenderer sprite;
    private bool isGrounded = false;



    public override void ReceiveDamage()
    {
        State = CharState.TakeDamage;
        Lives--;
        if (Lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        rigidbody.velocity = Vector3.zero;
        rigidbody.AddForce(transform.up * 20.0F, ForceMode2D.Impulse);
        Debug.Log(Lives);
        
    }


    private void Awake()
    {
        livesBar = FindObjectOfType<LivesBar>();
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        ChekGround();
    }
    private void Update()
    {
        if (isGrounded)State = CharState.Stand;



        if (Input.GetButton("Horizontal")) Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();
    }
    private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0F;

        if(isGrounded) State = CharState.Run ;
    }
    private void Jump()
    {
        State = CharState.Jump;
        rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    private void ChekGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1.5F);

        isGrounded = colliders.Length > 2;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.gameObject.GetComponent<Unit>();
        if (unit)
        {
            ReceiveDamage();
        }
    }
}

public enum CharState
{
    Stand,   //0
    Run,     //1
    Jump,    //2
    TakeDamage,   //3
}
