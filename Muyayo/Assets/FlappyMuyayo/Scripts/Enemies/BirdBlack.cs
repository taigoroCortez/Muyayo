using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBlack : BaseMovement
{
    public float velocidadLineal = 2.0f;
    public float velocidadAngular = 2.0f;
    public float amplitud = 2.0f;

    void Update()
    {
        BaseMove();
        EnemyBlackMove();
    }

    void EnemyBlackMove()
    {
        float tiempo = Time.time;

        // Calcular las posiciones en X e Y usando la función seno y coseno
        float posX = Mathf.Sin(tiempo * velocidadAngular) * amplitud;
        float posY = Mathf.Cos(tiempo * velocidadAngular) * amplitud;

        // Calcular el desplazamiento en línea recta
        //float desplazamientoLineal = tiempo * velocidadLineal;

        // Aplicar las posiciones al objeto
        //transform.position = new Vector3(posX , posY, transform.position.z);
    }
}






