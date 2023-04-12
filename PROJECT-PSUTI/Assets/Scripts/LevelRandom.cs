using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRandom : MonoBehaviour
{
    public int levelGenerate;

    public void LoadRandLevel()
    {
        levelGenerate = Random.Range(1, 4);
        SceneManager.LoadScene(levelGenerate);


    }

}
