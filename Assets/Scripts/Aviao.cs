using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float velocity = 0.5f;

    private Diretor diretor;

    private Vector3 posicaoInicial;

    private void Awake() {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Start() {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            this.Impulsionar();
        }
    }

    private void Impulsionar() {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * velocity, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void Reiniciar() {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
