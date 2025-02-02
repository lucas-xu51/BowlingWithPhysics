using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float score = 0;

    [SerializeField] private BallController ball;
    [SerializeField] private GameObject pinCollection;
    [SerializeField] private Transform pinAnchor;
    [SerializeField] private InputManager inputManager;

    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] fallTriggers;
    private GameObject pinObjects;

    void Start()
    {
        

        inputManager.OnResetPressed.AddListener(HandleReset);
        SetPins();
        pinCollection.SetActive(false);
    }

    private void HandleReset()
    {
        ball.ResetBall();
        pinCollection.SetActive(true);
        SetPins();
        pinCollection.SetActive(false);
    }

    private void SetPins()
    {
        if(pinObjects)
        {
            foreach (Transform child in pinObjects.transform)
            {
                Destroy(child.gameObject);
            }
            Destroy(pinObjects);
        }

        pinObjects = Instantiate(pinCollection, 
            pinAnchor.transform.position, 
            Quaternion.identity, transform);

        fallTriggers = FindObjectsByType<FallTrigger>(FindObjectsInactive.Include, 
            FindObjectsSortMode.None);

        foreach(FallTrigger pin in fallTriggers)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    private void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
