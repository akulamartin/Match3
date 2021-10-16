using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grids : MonoBehaviour
{
    public enum PieceType{
        NORMAL,
        COUNT
    }
    [System.Serializable]
    public struct PiecePrefab{
        public PieceType type;
        public GameObject prefab;
    }
    private Dictionary<PieceType,GameObject> piecePrefabDict;
    public int xDim;
    public int yDim;
    public PiecePrefab[] piecePrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
