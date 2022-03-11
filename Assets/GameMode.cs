using UnityEngine;

public class GameMode : MonoBehaviour
{
    void Start() {
        _gameTirggerToCatch.onEnter += (Collider2D enteredTrigger)=>
        {
            if (_triggerThatCaching == enteredTrigger)
                processCatched();
        };

        _gameTriggerToBruht.onEnter += (Collider2D enteredTrigger) =>
        {
            if (_triggerThatBruhting == enteredTrigger)
                processBruhed();
        };
    }

    void processBruhed() {
        _menu.showAsWin();
    }

    void processCatched() {
        _menu.showAsLoose();
    }

    [SerializeField]
    private GameTrigger _gameTirggerToCatch = null;

    [SerializeField]
    private Collider2D _triggerThatCaching = null;

    [SerializeField]
    private GameTrigger _gameTriggerToBruht = null;

    [SerializeField]
    private Collider2D _triggerThatBruhting = null;

    [SerializeField]
    private MenuScript _menu = null;
}
