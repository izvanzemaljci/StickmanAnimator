using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Button savePosition = null;
    [SerializeField]
    private Button copyPosition;
    [SerializeField]
    private Button pastePosition;
    [SerializeField]
    private Button deletePosition;
    [SerializeField]
    private Button previousFrame = null;
    [SerializeField]
    private Button nextFrame = null;
    [SerializeField]
    private Button newFrame = null;
    [SerializeField]
    private Button deleteFrame;
    [SerializeField]
    private Button copyFrame;
    [SerializeField]
    private Button pasteFrame;
    [SerializeField]
    private Button playAnimation = null;
    [SerializeField]
    private Button newAnimation;
    [SerializeField]
    private Button saveAnimation;
    [SerializeField]
    private Button loadAnimation;
    [SerializeField]
    private Text frameNumber = null;

    FrameController frameController = default;
    Frame frame = default;
    int currentFrame = 0;


    // Start is called before the first frame update
    void Start()
    {
        frameController = new FrameController();
        frame = new Frame();
        previousFrame.onClick.AddListener(toPreviousFrame);
        nextFrame.onClick.AddListener(toNextFrame);
        newFrame.onClick.AddListener(addFrame);
        playAnimation.onClick.AddListener(onPlayAnimation);
        savePosition.onClick.AddListener(saveCurrentPosition);
    }

    // Update is called once per frame
    void Update()
    {
        frameNumber.text = currentFrame.ToString();
    }

    public void toPreviousFrame() {
        currentFrame--;
    }

    public void toNextFrame() {
        currentFrame++;
        frame = new Frame();
    }

    public void addFrame() {
        frameController.newFrame();
        currentFrame = frameController.getNumberOfFrames();
    }

    public void onPlayAnimation() {
        StartCoroutine("startPlayingAnimation");
    }

    public void saveCurrentPosition() {
        this.frame.initConnectorCoords();
        this.frame.connectorsToDictionary();
        frameController.frameToDictionary(currentFrame, frame.getConnectors());
    }

    private IEnumerator startPlayingAnimation() {
        foreach(KeyValuePair<int, Dictionary<string,Vector2>> value in frameController.getFrames())
        {
            Debug.Log(value.Key); 
            frame.initConnectorCoords(value.Value);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
