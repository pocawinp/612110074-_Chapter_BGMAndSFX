using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YEET : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Text>().text = SingletonGameManager.Instance.GameScore.ToString();
        GetComponent<Text>().text = SingletonGameApplicationManager.Instance.DIFFICULTY_LEVEL_NAMES[SingletonGameApplicationManager.Instance.DifficultyLevel];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
