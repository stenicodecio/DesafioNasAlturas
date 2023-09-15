using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{

    [SerializeField]
    private GameObject manualDeInstrucoes;
    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;

    private void Awake() {
        this.ReiniciarCronometro();
    }

    private void Update()
    {

        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0) {
            this.ReiniciarCronometro();

            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
        }
    }

    private void ReiniciarCronometro() {
        this.cronometro = this.tempoParaGerar;
    }
}
