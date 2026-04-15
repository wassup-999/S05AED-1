using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public CustomDoubleLinkedList snapshotSystem =new();
    public Player player;
    public Enemies enemies;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }
    void Update()
    {

    }
    [Button]
    public void SaveTurn()
    {
        snapshotSystem.SaveTurn();
    }
    
    public void LoadTurn()
    {
        snapshotSystem.LoadTurn(player);
    }

    [Button]
    public void NexTurn()
    {
        snapshotSystem.MoveForward();
        LoadTurn();
    }
    [Button]
    public void PrevTurn()
    {
        snapshotSystem.MoveBackwards();
        LoadTurn();
    }
}