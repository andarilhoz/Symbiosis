using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    public int speedPlayer;
    public Rigidbody2D playerRigibody;
    public int jumpForce;
    public LayerMask whatIsGround;
    public float groundCheckRadious;
    public Transform groundCheck;
    private bool grounded;
    public float jumpTime;
    private float jumpTimeCounter;

    private bool stoppedJumping;

    private Animator myAnimator;


    // Use this for initialization
    void Start () {
        playerRigibody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadious, whatIsGround);
        playerRigibody.velocity = new Vector2(speedPlayer, playerRigibody.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded) {
                playerRigibody.velocity = new Vector2(playerRigibody.velocity.x, jumpForce);
                stoppedJumping = false;
            }            
        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && !stoppedJumping)
        {
            if (jumpTimeCounter > 0)
            {
                playerRigibody.velocity = new Vector2(playerRigibody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
            stoppedJumping = true;
        }

        if (grounded)
        {
            jumpTimeCounter = jumpTime;
        }

        myAnimator.SetBool("Grounded", grounded);
    }
}
