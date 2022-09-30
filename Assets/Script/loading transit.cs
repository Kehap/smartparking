
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTransition : MonoBehaviour
{
    [SerializeField] private GameObject logo;
    [SerializeField] private Text loading;
    [SerializeField] private float speed = 2;
    [SerializeField] private int maxDotCount = 5;

    [SerializeField] private GameObject buttonGroup;
    [SerializeField] private GameObject languageGroup;
    [SerializeField] private GameObject menuButton;


    private int dotCount = 0;
    private bool transitionShouldStart;
    private float lastDotTime;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(logo);
    }

    // Update is called once per frame
    void Update()
    {
        if (loading.gameObject.activeSelf && Time.time - lastDotTime >= speed) 
        {
            dotCount += 1;
            if (dotCount == maxDotCount) 
            {
                transitionShouldStart = true;
            }
            dotCount = dotCount % maxDotCount;

            lastDotTime = Time.time;

            loading.text = "Loading";
            for (int i=0; i<dotCount; i++) 
            {
                loading.text = loading.text + ".";
            }
        }

        if (transitionShouldStart)
        {
            // Text gameObject SetActive(false)
            loading.gameObject.SetActive(false);
            // loading.gameObject
            Debug.Log(logo);
            RectTransform rect = logo.GetComponent<RectTransform>();
            // Move the logo to 
            // 4 850 0
            StartCoroutine(MoveToTarget(rect, new Vector3(4, 2000, 0), speed));
            // 383 425
            // Scale the logo to 1 1 1
            StartCoroutine(ScaleToTarget(rect, new Vector3(1, 1, 1), speed));
            // set button group to active            
            // set language group to active
            StartCoroutine(ShowMenuComponents());

            transitionShouldStart = false;

        }
    }

    private IEnumerator ShowMenuComponents()
    {
        yield return new WaitForSeconds(1);
        buttonGroup.SetActive(true);
        languageGroup.SetActive(true);
        menuButton.SetActive(true);

    }

    private IEnumerator MoveToTarget(RectTransform rect, Vector3 target, float speed)
    {
        while (Mathf.Abs(Vector3.Distance(rect.localPosition, target)) > 5f)
        {
            rect.localPosition = Vector3.Lerp(rect.localPosition, target, Time.deltaTime*speed);
            yield return null;
        }
    }
    private IEnumerator ScaleToTarget(RectTransform rect, Vector3 target, float speed)
    {
        while (Mathf.Abs(Vector3.Distance(rect.localScale, target)) > 0.1f)
        {
            rect.localScale = Vector3.Lerp(rect.localScale, target, Time.deltaTime*speed);
            yield return null;
        }
    }
}


