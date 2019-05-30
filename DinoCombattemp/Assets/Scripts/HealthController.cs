using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable { void Damage(int damage); }
public class HealthController : MonoBehaviour, IDamageable
{
  public  int health = 8;
    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0) { Destroy(gameObject); }
    }
}