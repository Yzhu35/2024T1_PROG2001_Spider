using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class YinghaoButtonController : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip clickSound;
    public AudioClip hoverSound;
    private Button button;
    private AudioSource audioSource;
    public string sceneName = "Menu";

    void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();

        button.onClick.AddListener(ClickHandler);
    }

    void ClickHandler()
    {
        audioSource.PlayOneShot(clickSound);
        if (button.name == "Menu")
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hoverSound);
    }
}
