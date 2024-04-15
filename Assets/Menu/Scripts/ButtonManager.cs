using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip clickSound;
    public AudioClip hoverSound;
    private Button button;
    private AudioSource audioSource;
    public string sceneName = "YinghaoScene";

    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();

        button.onClick.AddListener(ClickHandler);
    }

    void ClickHandler()
    {
        if (button.name == "Start")
        {
            SceneManager.LoadScene(sceneName);
        }
        audioSource.PlayOneShot(clickSound);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hoverSound);
    }
}
