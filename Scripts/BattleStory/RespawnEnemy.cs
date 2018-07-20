using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnEnemy : MonoBehaviour {

    public Character enemy;
    public EnemyDefinition[] enemies;
    public Image sprite;
    public BoolVariable inBattle;
    public IntVariable enemyIndex;

    // Use this for initialization
    void Start () {
		
	}
	
    public void SpawnEnemy()
    {
        enemyIndex.RuntimeValue = Random.Range(0, enemies.Length);
        enemy.ApplyPreset(enemies[enemyIndex.RuntimeValue]);
    }

    // Update is called once per frame
    void Update () {
        if (enemy.IsDead && !inBattle.RuntimeValue)
            SpawnEnemy();
        sprite.sprite = enemies[enemyIndex.RuntimeValue].sprite;
        enemy.color = enemies[enemyIndex.RuntimeValue].color;
    }
}
