using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class BumperController : MonoBehaviour
{
    private Renderer renderer;
    private Animator animator;

    public float score;
    public ScoreManager ScoreManager;
    public float multiplier;
    public Collider bola;
    public Color color;
    public AudioManager audioManager;
    public VFXManager VFXManager;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        GetComponent<Renderer>().material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;
            animator.SetTrigger("Hit");
            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
            //tambah score saat menabrak bumper
            ScoreManager.AddScore(score);
        }
    }
}
