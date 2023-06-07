
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PositionGrid : MonoBehaviour
{
    public int gridLength = 9;
    public int gridWidth = 11;
    public float cellSizeX = 5.3f;
    public float cellSizeZ = 6f;
    public int cellX;
    public int cellZ;


    public void Update()
    {
 
        Vector3 position = transform.position - new Vector3(cellSizeX / 2f, 0f, cellSizeZ / 2f);


        cellX = Mathf.FloorToInt((position.x / cellSizeX) * gridLength) * -1 + 5;
        cellZ = Mathf.FloorToInt((position.z / cellSizeZ) * gridWidth) + 23;


        Debug.Log("Estás en la celda: X = " + cellX + ", Z = " + cellZ);
    }

    public int GetMycellX()
    {
        return cellX; // Retornar el valor de la variable
    }

    public int GetMycellZ()
    {
        return cellZ; // Retornar el valor de la variable
    }

}
