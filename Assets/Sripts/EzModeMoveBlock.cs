using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EzModeMoveBlock : MonoBehaviour
{
    [SerializeField] Image redBlock;
    [SerializeField] Image blueBlock;
    [SerializeField] Button redBtn;
    [SerializeField] Button blueBtn;
    [SerializeField] TextMeshProUGUI countDown;
    [SerializeField] GameObject panel;



    int screenHeight;
    float time = 3f;


    void Start()
    {
        panel.SetActive(true);

        screenHeight = Screen.height;
        redBlock.transform.position = new Vector3(0f, -5.0f);
    }


    void Update()
    {
        time -= Time.deltaTime;


        if (redBlock.transform.position.y >= 0f)
            SceneManager.LoadScene(2);
        else if (redBlock.transform.position.y <= -10f)
            SceneManager.LoadScene(3);


        countDown.text = Mathf.Round(time).ToString();

        if (Mathf.Round(time) == 0)
        {
            panel.SetActive(false);
        }
    }
    public void MoveBlueBlock()
    {
        if (redBlock.transform.position.y < 0 && redBlock.transform.position.y > -screenHeight)
            redBlock.transform.position -= Vector3.up / 4;
    }

    public void MoveRedBlock()
    {
        if (redBlock.transform.position.y < 0 && redBlock.transform.position.y > -screenHeight)
            redBlock.transform.position += Vector3.up / 4;
    }
}
