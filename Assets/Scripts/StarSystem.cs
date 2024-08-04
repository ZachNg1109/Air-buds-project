using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
    public int starCount;

    public TextMeshProUGUI starText;

    private void Update()
    {
        starText.text = starCount.ToString();
    }

}
