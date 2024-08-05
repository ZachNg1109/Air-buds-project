using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGlobe : MonoBehaviour
{
    public CharactersObjects characterList;
    public GameObject coin;
    public Canvas coinCanvas;
    public ScreenPause pauser;
    public GameObject obstacleTest;
    public GameObject middleRef;

    public float speed = 20f;

    private float duration = 0f;
    private Canvas currentCanvas;

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
        
        
        Instantiate(coin, middleRef.transform.position, middleRef.transform.rotation);
         
    }
}
