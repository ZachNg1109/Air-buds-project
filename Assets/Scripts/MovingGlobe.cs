using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGlobe : MonoBehaviour
{
    public CharactersObjects characterList;
    public GameObject coin;
    public Canvas coinCanvas;
    public ScreenPause pauser;
    private Canvas currentCanvas;
    public GameObject obstacleTest;

    public float speed = 20f;
    private float duration = 0f;

    int y = 0;

    private void Awake()
    {
        //if(characterList.Tappy == true)
        //{
        //    speed = 22f;
        //}

        //if (characterList.Bam == true)
        //{
        //    speed = 19f;
        //}

        //if (characterList.Biggie == true)
        //{
        //    speed = 20f;
        //}

        //if (characterList.Ogu == true)
        //{
        //    speed = 21f;
        //}
    }

    private void Update()
    {
        

        

        


        if (Input.GetKeyDown(KeyCode.Y))
        {
            pauser.PauseScreen();
        }

      

        if (speed != 20)
        {
            duration += Time.deltaTime;
            if (duration > 2f)
            {
                speed = 20;
                duration = 0;
            }
        }

        if (currentCanvas == null)
        {
            return;
            
        }
        else
            Invoke("DesCanvas", 2.5f);

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
      
        this.transform.Rotate(speed * Time.deltaTime, 0, 0);
        
    }

    private void DesCanvas()
    {
        currentCanvas.enabled = false;
    }

    public void CoinChallenge()
    {
        currentCanvas = coinCanvas;

        coinCanvas.enabled = true;
        int x = 1;
        for (int n = 0; n < 10; n++)
        {
            Instantiate(coin, new Vector3(0.815f * Mathf.Pow(-1f, x), 3.65f, -1.6f + x), Quaternion.identity);
            x++;
        }
    }
}
