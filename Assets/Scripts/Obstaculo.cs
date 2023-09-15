using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocity = 0.6f;
    [SerializeField]
    private float variacaoDaPosicaoY = 0.7f;

    private void Awake() {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * velocity * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
       this.Destruir();
    }

    public void Destruir() {
        GameObject.Destroy(this.gameObject);
    }
}
