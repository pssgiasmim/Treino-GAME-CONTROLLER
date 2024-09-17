using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject blockPrefab; //prefab do bloco

    public int linha = 5; //quantidade de linhas na matriz

    public int coluna = 5; //quantidade de colunas na matriz

    public float spacing = 1.1f; //tamanho do espaçamento entre blocos

    private GameObject[,] grid; //variável da matriz 2D que armazena os blocos

    
    //Método que inicializa a matriz com a quantidade de linhas e colunas
    private void Start()
    {
        //inicializa a matriz com a quantidade de linhas e colunas
        grid = new GameObject[linha, coluna];

        //chamando o método de criar o grid para criar o grid(matriz)
        CreateGrid();

    }
        
    //Método para criar a matriz
    private void CreateGrid()
    {
        //loop que cria a matriz. Esse mesmo loop cálcula a posição de cada boloco e armazena
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                //variável que armazena as posições dos blocos
                Vector2 posicao = new Vector2( i, j); //a posição em linha e coluna, é armazenado na variável posicao

                //Instancia o bloco na posição calculada
                GameObject bloco =Instantiate(blockPrefab, posicao, Quaternion.identity);

                //Armazena o bloco na matriz
                grid[i , j] = bloco;

            }
        }
    }

   



}
