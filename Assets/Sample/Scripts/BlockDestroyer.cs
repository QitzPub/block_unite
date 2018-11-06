using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlockDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FillScreen();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    void FillScreen(){
        SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();

        float worldScreenHeight = Camera.main.orthographicSize * 2f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        float width = sRenderer.sprite.bounds.size.x;
        float height = sRenderer.sprite.bounds.size.y;

        transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height);

        Vector3 camPos = Camera.main.transform.position;

        camPos.z = 1;

        transform.position = camPos;
    }
}
