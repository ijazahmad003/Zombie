using UnityEngine;
using System.Collections;


public class Spawn : MonoBehaviour
{
  // Spawn location
  public Vector3 spawnLocation = Vector3.zero;
  // Spawn radius (Gives a bit more randomness factor to the spawn location)
  public float spawnRadius = 1.0f;
  // Spawn timer (seconds)
  public float spawnTimer = 5.0f;
  private float spawnTimeRemaining = 5.0f;


  // The zombie to spawn
  public GameObject zombiePrefab = null;


  void Awake()
  {
    spawnTimeRemaining = spawnTimer;
  }


  void FixedUpdate()
  {
    spawnTimeRemaining -= Time.deltaTime;


 if (spawnTimeRemaining < 0.0f)
 {
   Vector2 circlePosition = Random.insideUnitCircle * spawnRadius;
   GameObject.Instantiate(zombiePrefab, spawnLocation + new Vector3(circlePosition.x, 0.0f, circlePosition.y), Quaternion.identity);
   spawnTimeRemaining = spawnTimer;
 }

  }
}