using UnityEngine;
using UnityEngine.Tilemaps;
public class tilemapdissabler : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
