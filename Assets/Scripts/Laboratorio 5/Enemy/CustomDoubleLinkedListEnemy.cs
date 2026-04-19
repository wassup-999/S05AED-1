using UnityEngine;

public class CustomDoubleLinkedListEnemy : DoubleLinkedList<SnapshotNode>
{
    
    public Node<SnapshotNode> pointer;
    public void SaveTurnEnemy()
    {
        if (pointer == tail)
        {           

            SnapshotNode snapshot2 = new SnapshotNode(GameManager.instance.enemies, Count);
            base.Add(snapshot2);
            ResetPointerEnemy();
        }
        else
        {
            RemoveFromPosition(pointer);
            
            SnapshotNode snapshot2 = new SnapshotNode(GameManager.instance.enemies, Count); 
            

            base.Add(snapshot2);
            ResetPointerEnemy();
        }
    }
    public void ResetPointerEnemy()
    {
        pointer = tail;

    }
    public void MoveBackwardsEnemy()
    {
        if (pointer.Prev == null) return;

        pointer = pointer.Prev;
    }
    public void MoveForwardEnemy()
    {
        if (pointer.Next == null) return;
        pointer = pointer.Next;
    }
    public void LoadTurn(Enemy enemy)
    {
        Debug.Log("Cargando el Turno" + pointer.Value.EnemyTurn);
        enemy.transform.position = pointer.Value.enemyPosition;
        enemy.transform.eulerAngles = pointer.Value.enemyRotation;
        enemy.Enmydmg = pointer.Value.Enmydmg;
        enemy.Enmyspd = pointer.Value.Enmydmg;        
    }
}
