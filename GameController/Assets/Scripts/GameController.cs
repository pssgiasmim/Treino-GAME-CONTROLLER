using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject blockPrefab; //prefab do bloco

    public int linha = 5; //quantidade de linhas na matriz

    public int coluna = 5; //quantidade de colunas na matriz

    public float spacing = 1.1f; //tamanho do espa�amento entre blocos

    private GameObject[,] grid; //vari�vel da matriz 2D que armazena os blocos

    
    //M�todo que inicializa a matriz com a quantidade de linhas e colunas
    private void Start()
    {
        //inicializa a matriz com a quantidade de linhas e colunas
        grid = new GameObject[linha, coluna];

        //chamando o m�todo de criar o grid para criar o grid(matriz)
        CreateGrid();

    }
        
    //M�todo para criar a matriz
    private void CreateGrid()
    {
        //loop que cria a matriz. Wsse mesmo loop c�lcula a posi��o de cada boloco e armazena
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                //vari�vel que armazena as posi��es dos blocos
                Vector2 posicao = new Vector2( i, j); //a posi��o em linha e coluna, � armazenado na vari�vel posicao

                GameObject bloco=Instantiate(blockPrefab, posicao, Quaternion.identity);

                grid[i , j] = bloco;


            }
        }
    }

   


}
