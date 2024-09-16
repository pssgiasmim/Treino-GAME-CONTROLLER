using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Block : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; ////Variavel do tipo SpriteRenderer

    

    //Método responsavel por trocar a sprite
    private void Start()
    {
        // Obtém o componente SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>(); 

        // A alteração da cor do bloco vai ocorrer em ChangeColor();

    }


    //Método que verifica se o bloco foi clicado
    private void OnMouseDown() //O OnMouseDown já verifica automaticamente se o elemento já foi clicado
    {
        ChangeColor(); // Muda a cor do bloco quando ele for clicado
    }


    //Método para trocar a cor do bloco aleatóriamente
    private void ChangeColor()
    {
        s = new Color(1,1,1);//SpriteRenderer.color = new Color(repetir o random. range)
    }

}
