using UnityEngine;

public class CustomDoubleLinkedListEnemy : DoubleLinkedList<SnapshotNode>
{
    public Node<SnapshotNode> pointer;
    public void SaveTurn()
    {
        if (pointer == tail)
        {
            SnapshotNode snapshot = new SnapshotNode(GameManager.Instance.enemies, Count);
            base.Add(snapshot);
            ResetPointer();
        }
        else
        {
            RemoveFromPosition(pointer);
            SnapshotNode snapshot = new SnapshotNode(GameManager.Instance.enemies, Count);
            base.Add(snapshot);
            ResetPointer();
        }
    }
    public void ResetPointer()
    {
        pointer = tail;

    }
    public void MoveBackwards()
    {
        if (pointer.Prev == null) return;

        pointer = pointer.Prev;
    }
    public void MoveForward()
    {
        if (pointer.Next == null) return;
        pointer = pointer.Next;
    }
    public void LoadTurn(Enemies enemy)
    {
        Debug.Log("Cargando el Turno" + pointer.Value.Turn);
        enemy.transform.position = pointer.Value.enemyPosition;
        enemy.transform.eulerAngles = pointer.Value.enemyRotation;
        enemy.Enmydmg = pointer.Value.Enmydmg;
        enemy.Enmyspd = pointer.Value.Enmydmg;        
    }
}
