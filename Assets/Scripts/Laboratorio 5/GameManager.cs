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
    public Enemy enemies;
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
    public void SaveTurnPlayer()
    {      
        snapshotSystem.SaveTurn();        
    }
    public void LoadTurnPlayer()
    {
        snapshotSystem.LoadTurn(player);
    }

    [Button]
    public void NexTurnPlayer()
    {

        snapshotSystem.MoveForward();
        LoadTurnPlayer();
    }
    [Button]
    public void PrevTurnPlayer()
    {
        snapshotSystem.MoveBackwards();
        LoadTurnPlayer();
    }

    /// 
    /// 
    /// 


    [Button]
    public void SaveTurnEnemy()
    {
        snapshotSystemEnemy.SaveTurnEnemy();
    }

    public void LoadTurnEnemy()
    {
        snapshotSystemEnemy.LoadTurn(enemies);
    }
   
    [Button]
    public void NexTurnEnemy()
    {              
        snapshotSystemEnemy.MoveForwardEnemy();
        LoadTurnEnemy();
    }
    
    [Button]
    public void PrevTurnEnemy()
    {       
        snapshotSystemEnemy.MoveBackwardsEnemy();
        LoadTurnEnemy();
    }
}