using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Block : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; ////Variavel do tipo SpriteRenderer

    

    //M�todo responsavel por trocar a sprite
    private void Start()
    {
        // Obt�m o componente SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>(); 

        // A altera��o da cor do bloco vai ocorrer em ChangeColor();

    }


    //M�todo que verifica se o bloco foi clicado
    private void OnMouseDown() //O OnMouseDown j� verifica automaticamente se o elemento j� foi clicado
    {
        ChangeColor(); // Muda a cor do bloco quando ele for clicado
    }


    //M�todo para trocar a cor do bloco aleat�riamente
    private void ChangeColor()
    {
        s = new Color(1,1,1);//SpriteRenderer.color = new Color(repetir o random. range)
    }

}
