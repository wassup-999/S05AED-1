using UnityEngine;

public class SnapshotNode 
{
    public int Turn;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public int str;
    public int dtx;
    public int spd;

    //Enemy
    public int EnemyTurn;
    public Vector3 enemyPosition;
    public Vector3 enemyRotation;
    public int Enmyspd;
    public int Enmydmg;
    public SnapshotNode(Player player, int turn )
    {
        Turn = turn;

        playerPosition = player.transform.position;
        playerRotation = player.transform.rotation.eulerAngles;
        str = player.str;
        dtx = player.dtx;
        spd = player.spd;              
    }
    public SnapshotNode(Enemies enemy , int turn)
    {
        EnemyTurn = turn;
        enemyPosition = enemy.transform.position;
        enemyRotation = enemy.transform.rotation.eulerAngles;
        Enmyspd = enemy.Enmyspd;
        Enmydmg = enemy.Enmydmg;
    }
}
