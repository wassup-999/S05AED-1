using UnityEngine;

public class RecursiveClass : MonoBehaviour
{
    
    void Start()
    {
        //CountDown(5);
        Debug.Log(Sum(5));
    }

    
    void Update()
    {
        
    }
    //Para que sea recursivo se tiene que llamar el metodo asi mismo
    //-->Ejemplo:
    public void CountDown(int n)
    {
        if (n <= 0)
        {
            Debug.Log("Inicio de juego");
            return;
        }
        Debug.Log(n - 1);
        CountDown(n);       
    }
    public int Sum(int n)
    {
        if (n == 1)
            return 1;
        return n + Sum (n-1);
    }
}
