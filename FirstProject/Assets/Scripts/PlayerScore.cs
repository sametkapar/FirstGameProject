using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
