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
    private Button stopAnimation = null;
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

    void Start()
    {
        frameController = new FrameController();
        frame = new Frame();
        previousFrame.onClick.AddListener(toPreviousFrame);
        nextFrame.onClick.AddListener(toNextFrame);
        newFrame.onClick.AddListener(addFrame);
        playAnimation.onClick.AddListener(onPlayAnimation);
        stopAnimation.onClick.AddListener(onStopAnimation);
        savePosition.onClick.AddListener(saveCurrentPosition);
    }

    void Update()
    {
        frameNumber.text = currentFrame.ToString();
    }

    public void toPreviousFrame() {
        if(currentFrame > 0) {
            currentFrame--;
        } 
    }

    public void toNextFrame() {
        while(currentFrame < frameController.getNumberOfFrames()) {
            currentFrame++;
            frame = new Frame();
        } 
    }

    public void addFrame() {
        frameController.newFrame();
        currentFrame = frameController.getNumberOfFrames();
    }

    public void onPlayAnimation() {
        StartCoroutine("startPlayingAnimation");
    }

    public void onStopAnimation() {
        StopCoroutine("startPlayingAnimation");
    }

    public void saveCurrentPosition() {
        this.frame.initConnectorCoords();
        this.frame.connectorsToDictionary();
        frameController.frameToDictionary(currentFrame, frame.getConnectors());
    }

    private IEnumerator startPlayingAnimation() {
        while(true) {
            foreach(KeyValuePair<int, Dictionary<string,Vector3>> value in frameController.getFrames())
            {
                Debug.Log(value.Key); 
                currentFrame = value.Key;
                frame.initConnectorCoords(value.Value);
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
