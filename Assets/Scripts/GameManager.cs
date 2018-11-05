using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    float feverScore;

    [SerializeField] Text scoreText;
    [SerializeField] Text feverRatioText;
    [SerializeField] Button FeverButton;
    [SerializeField] GameObject FeverRatioMeter;
    RaycastHit2D hit;

    // Update is called once per frame
    void Update()
    {
        DetectBlock();
        ActivateFeverButton();
    }

    void DetectBlock(){
        if(Input.GetButtonDown("Fire1")){
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.rigidbody != null){
                AddScore();
                AddFeverScore();
                Destroy(hit.transform.gameObject);
            }
        }
    }
    void AddScore(){
        score += (int)Mathf.Pow(hit.transform.GetComponent<Rigidbody2D>().mass, 2);
        scoreText.text = score.ToString();
    }
    void AddFeverScore(){
        if(hit.transform.GetComponent<Rigidbody2D>().mass > 1){
            feverScore = hit.transform.GetComponent<Rigidbody2D>().mass / 30;
            FeverRatioMeter.GetComponent<Image>().fillAmount += feverScore;
            feverRatioText.text = FeverRatioMeter.GetComponent<Image>().fillAmount.ToString("00%");
        }
    }
    void ActivateFeverButton(){
        if(FeverRatioMeter.GetComponent<Image>().fillAmount == 1){
            ToggleFeverButton(true);
        }
    }
    public void ToggleFeverButton(bool isActive){
        FeverButton.interactable = isActive;
    }
    public void ResetFeverScore(){
        feverScore = 0;
        FeverRatioMeter.GetComponent<Image>().fillAmount = feverScore;
        feverRatioText.text = "00" + "%";
    }
    public void ResetScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
