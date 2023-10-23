using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1000)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public List<WayPoint> enemiesWaypoint = null;
    public List<EnemyBrain> enemies = null;
    public HeroBrain player = null;


    public HeroBrain hero = null;
    public EnemyBrain enemy = null;


    public Func<float> GetEnemyDamage = null;



    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        GetEnemyDamage = enemy.GetMyDamage;
        hero.GetEnemeyDamage = GetEnemyDamage;

        ObjectPooling.OnObjectPooled.AddListener(OnBulletPolled);
    }





    private void OnBulletPolled(IPool objectPooled)
    {
        
    }

    private void OnDestroy()
    {
        Instance = null;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {

    }

    private void OnPlayerHealthChanged()
    {
        Debug.Log("GameManager Trigger OnHealthChange");
    }
}
