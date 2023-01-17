
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public ParticleSystem dirtParticle;
    public ParticleSystem explosionParticle;

    private Rigidbody playerRb;

    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;

    public bool gameOver = false;

    private Animator playerAnim;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            dirtParticle.Stop();
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }

    }


}
