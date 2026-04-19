using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public CustomDoubleLinkedList snapshotSystem =new();
    public CustomDoubleLinkedListEnemy snapshotSystemEnemy = new();
    public Player player;
    public Enemies enemies;
    private void Awake()
    {
        instance = this;
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
        snapshotSystemEnemy.SaveTurn();
    }
    
    public void LoadTurn()
    {
        snapshotSystem.LoadTurn(player);
        snapshotSystemEnemy.LoadTurn(enemies);
    }

    [Button]
    public void NexTurn()
    {
        snapshotSystem.MoveForward();
        snapshotSystemEnemy.MoveForward();
        LoadTurn();
    }
    [Button]
    public void PrevTurn()
    {
        snapshotSystem.MoveBackwards();
        snapshotSystemEnemy.MoveBackwards();
        LoadTurn();
    }
}