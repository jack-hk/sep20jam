using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    private AudioSource audioSource;

    public LayerMask whatIsEnemy;
    public float attackRange;
    public Transform attackPoint;

    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    //public LayerMask groundMask;

    Vector3 velocity;
    //bool isGrounded;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        /*if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        } */
        //Debug.Log(controller.velocity.magnitude);



        //Movement
        if (controller.velocity.magnitude > 0f && audioSource.isPlaying == false)
        {
            audioSource.volume = Random.Range(0.8f, 1); //audio pitch randomiser
            audioSource.pitch = Random.Range(0.8f, 1.1f);
            audioSource.Play();
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        //Attack
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            Attack(1);
        }
    }

    private void Attack(int damage)
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, whatIsEnemy);

        foreach(Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name + " | Damage: " + damage);
            enemy.GetComponent<EnemyAI>().TakeDamage(damage);
        }

        
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
