using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    [SerializeField] float force = 5f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void Jump()
    {
        rigid.velocity = new Vector2(0, force);
        anim.SetTrigger("Jump"); 
    }

    private void Update()
    {
        anim.SetFloat("VelocityY", rigid.velocity.y);

        float angle = Mathf.Clamp(rigid.velocity.y * 5f, -30f, 30f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            ControladorJuego.Instancia.FinalizarJuego();
        }
    }
}
