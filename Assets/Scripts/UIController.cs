using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Button savePosition = null;
    [SerializeField]
    private Button copyPosition = null;
    [SerializeField]
    private Button pastePosition = null;
    [SerializeField]
    private Button deletePosition = null;
    [SerializeField]
    private Button previousFrame = null;
    [SerializeField]
    private Button nextFrame = null;
    [SerializeField]
    private Button newFrame = null;
    [SerializeField]
    private Button deleteFrame = null;
    [SerializeField]
    private Button playAnimation = null;
    [SerializeField]
    private Button stopAnimation = null;
    [SerializeField]
    private Button previousTimeInterval = null;
    [SerializeField]
    private Button nextTimeInterval = null;
    [SerializeField]
    private Button newAnimation;
    [SerializeField]
    private Button saveAnimation;
    [SerializeField]
    private Button loadAnimation;
    [SerializeField]
    private Text frameNumber = null;
    [SerializeField]
    private Text timeIntervalNumber = null;

    FrameController frameController = default;
    Frame frame = default;
    Frame defaultFrame = default;
    Frame tempFrame = default;
    int currentFrame = 0;
    float currentTime = 0.5f;

    void Start()
    {
        frameController = new FrameController();
        frame = new Frame();

        defaultFrame = new Frame();
        defaultFrame.initConnectorCoords();
        defaultFrame.connectorsToDictionary();

        tempFrame = new Frame();

        previousFrame.onClick.AddListener(toPreviousFrame);
        nextFrame.onClick.AddListener(toNextFrame);
        newFrame.onClick.AddListener(addFrame);
        playAnimation.onClick.AddListener(onPlayAnimation);
        stopAnimation.onClick.AddListener(onStopAnimation);
        savePosition.onClick.AddListener(saveCurrentPosition);
        deletePosition.onClick.AddListener(deleteCurrentPosition);
        copyPosition.onClick.AddListener(copyCurrentPosition);
        pastePosition.onClick.AddListener(pasteCopiedPosition);
        deleteFrame.onClick.AddListener(deleteCurrentFrame);
        previousTimeInterval.onClick.AddListener(toPreviousTimeInterval);
        nextTimeInterval.onClick.AddListener(toNextTimeInterval);
    }

    void Update()
    {
        frameNumber.text = currentFrame.ToString();
        timeIntervalNumber.text = currentTime.ToString();
    }

    public void toPreviousFrame() {
        if(currentFrame > 0) {
            currentFrame--;
            if(frameController.doesFrameExist(currentFrame)) {
                this.frame.initConnectorCoords(frameController.frameAtIndex(currentFrame));
            } 
        } 
    }

    public void toNextFrame() {
        if(currentFrame < frameController.getNumberOfFrames()) {
            currentFrame++;
            if(frameController.doesFrameExist(currentFrame)) {
                this.frame.initConnectorCoords(frameController.frameAtIndex(currentFrame));
            }
        } 
    }

    public void addFrame() {
        frame = new Frame();
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
        frameController.frameToDictionary(currentFrame, this.frame.getConnectors());
    }

    public void deleteCurrentPosition() {
        this.frame.initConnectorCoords(defaultFrame.getConnectors());
    }

    public void copyCurrentPosition() {
        tempFrame.initConnectorCoords();
        tempFrame.connectorsToDictionary();
    }

    public void pasteCopiedPosition() {
        this.frame.initConnectorCoords(tempFrame.getConnectors());
    }

    public void deleteCurrentFrame() {
        frameController.deleteFrame(currentFrame);
    }

    public void toPreviousTimeInterval() {
        if(currentTime > 0.5f) {
            currentTime -= 0.5f;
        } 
    }

    public void toNextTimeInterval() {
        currentTime += 0.5f; 
    }

    private IEnumerator startPlayingAnimation() {
        while(true) {
            foreach(KeyValuePair<int, Dictionary<string,Vector3>> value in frameController.getFrames())
            {
                Debug.Log(value.Key); 
                currentFrame = value.Key;
                frame.initConnectorCoords(value.Value);
                yield return new WaitForSeconds(currentTime);
            }
        }
    }
}
