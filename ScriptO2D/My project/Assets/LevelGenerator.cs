using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private LevelSpec[] levelsSpecs;

    private int level = 0;


    private void Update()
    {
        if (Input.anyKey)
        {
            for (var i = 0; i < gameObject.transform.childCount; i++)
            {
                Destroy(gameObject.transform.GetChild(i).gameObject);
                
            }
            
            foreach (Vector2 pos in levelsSpecs[Mathf.Abs(level % levelsSpecs.Length)].EnemySpawnPoints)
            {
                Instantiate(enemyPrefab, pos, Quaternion.identity, gameObject.transform);
            }

            Camera.main.backgroundColor = levelsSpecs[Mathf.Abs(level % levelsSpecs.Length)].BackgroundColor;

            if (Input.GetKeyDown(KeyCode.D))
                level++;

            if (Input.GetKeyDown(KeyCode.A))
                level--;
        }

    }
}
