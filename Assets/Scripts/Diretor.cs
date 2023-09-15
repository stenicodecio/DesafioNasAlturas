using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;

    private void Start() {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
    }

    public void FinalizarJogo() {
        Time.timeScale = 0;
        this.imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo() {
        Time.timeScale = 1;
        this.imagemGameOver.SetActive(false);
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
    }

    private void DestruirObstaculos() {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos) {
            obstaculo.Destruir();
        }
    }
}
