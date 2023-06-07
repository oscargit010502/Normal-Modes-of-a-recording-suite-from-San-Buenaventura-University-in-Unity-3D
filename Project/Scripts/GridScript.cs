using UnityEngine;

public class GridScript : MonoBehaviour
{
    public int gridLength = 9;
    public int gridWidth = 11;
    public float cellSizeX = 5.3f;
    public float cellSizeZ = 6f;

    private void OnDrawGizmos()
    {
        Vector3 startPosition = transform.position - new Vector3(cellSizeX / 2f, 0f, cellSizeZ / 2f);

        for (int x = 0; x <= gridLength; x++)
        {
            Vector3 start = startPosition + new Vector3(x * (cellSizeX / gridLength), 0f, 0f);
            Vector3 end = start + new Vector3(0f, 0f, cellSizeZ);
            Gizmos.DrawLine(start, end);
        }

        for (int z = 0; z <= gridWidth; z++)
        {
            Vector3 start = startPosition + new Vector3(0f, 0f, z * (cellSizeZ / gridWidth));
            Vector3 end = start + new Vector3(cellSizeX, 0f, 0f);
            Gizmos.DrawLine(start, end);
        }
    }
}
