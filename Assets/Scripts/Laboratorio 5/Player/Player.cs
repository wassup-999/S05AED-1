using UnityEngine;

public class Player : MonoBehaviour
{
    
    [Header("Player Stats")]
    public int str;
    public int dtx;
    public int spdbuf;
    
    void Start()
    {
        str = Random.Range(1, 20);
        dtx = Random.Range(1, 10);
        spdbuf = Random.Range(1, 2);  
    }

    
    void Update()
    {
        
    }
}
