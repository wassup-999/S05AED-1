using UnityEngine;
using Sirenix.OdinInspector;

public class RecursiveClass : MonoBehaviour
{
    
    void Start()
    {
        
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
    [Button]
    public void PrintFlow(int n)
    {
        if (n < 1)
            return;
        Debug.Log("Entrando" + n);
        print(n - 1);
        Debug.Log("Saliendo" + n);
    }
    [Button]
    public int SumExpress(int n)
    {
        if (n == 1)
            return 1;
        return SumExpress(n - 1) + SumExpress(n -1);
    }
    [Button]
    public int Factorial(int n)
    {
        if(n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    [Button]
    public int Fibonacci(int n)
    {
        if(n==0)
            return 0;
        if(n == 1)
            return 1;

        return Fibonacci (n - 1) + Fibonacci(n-2);
    }

}
